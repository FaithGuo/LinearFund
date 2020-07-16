using EasyHttp.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace LinearFund
{
    public class FundManager
    {
        //基金代码
        public string FundCode { get; set; }
        //基金名称
        public string FundName { get; set; }
        //查询数据开始时间
        public string BeginTime { get; set; }

        //查询数据结束时间
        public string EndTime { get; set; }

        //总页数
        public int TotalPage { get; set; }

        //页面大小
        public int PageSize { get; set; } = 20;

        //页面索引
        public int PageIndex { get; set; } = 1;

        //当前页数据
        public FundData Data { get; set; }

        private string url
        {
            get =>
$"http://api.fund.eastmoney.com/f10/lsjz?callback=jQuery18309279866857577859_{TimeHelp.GetTimeStamp(DateTime.Now)}&fundCode={FundCode}&pageIndex={PageIndex}&pageSize={PageSize}&startDate={BeginTime}&endDate={EndTime}&_={TimeHelp.GetTimeStamp(DateTime.Now)}"; set => url = value;
        }

        private HttpClient HttpClient = new HttpClient();

        /// <summary>
        /// 数据发生改变事件
        /// </summary>
        public event EventHandler<DataChangeEventArgs> DataChange;

        public FundManager()
        {
            HttpClient.Request.Referer = "http://fundf10.eastmoney.com/";
        }
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <returns></returns>
        public bool Get()
        {
            var response = HttpClient.Get(url);
            this.Data = JsonConvert.DeserializeObject<FundData>(response.RawText.JsonpTrim());
            this.TotalPage = (int)Math.Ceiling((double)(Data.TotalCount / PageSize));
            this.PageIndex = Data.PageIndex;
            this.PageSize = Data.PageSize;
            DataChange?.Invoke(this, new DataChangeEventArgs(Data));
            return true;
        }
        /// <summary>
        /// 获取下一页数据
        /// </summary>
        /// <returns></returns>
        public bool GetNext()
        {
            if (PageIndex + 1 <= TotalPage)
            {
                this.PageIndex++;
                return Get();
            }
            return false;
        }

        public void FindFundName()
        {
            var response= HttpClient.Get($"http://fundsuggest.eastmoney.com/FundSearch/api/FundSearchAPI.ashx?callback=jQuery18309279866857577859_1594904197598&m=1&key={FundCode}&_={TimeHelp.GetTimeStamp(DateTime.Now)}");
            string result = response.RawText;
            Console.WriteLine(result);
            this.FundName= Regex.Match(result, "NAME\":\"(.+?)\",\"JP").Groups[1].Value;
        }
    }
    public class DataChangeEventArgs : EventArgs
    {
        FundData fundData;
        public FundData FundData { get => fundData; }
        public DataChangeEventArgs(FundData _fundData)
        {
            fundData = _fundData;
        }

        
    }
    public static class StringExtension
    {
        public static string JsonpTrim(this string jsonp)
        {
            Regex reg = new Regex(@"(jQuery\d+?_\d+?\()");
            return reg.Replace(jsonp, "").Replace(")", "");
        }
    }
    public class LSJZList
    {
        public string FSRQ { get; set; }
        public string DWJZ { get; set; }
        public string LJJZ { get; set; }
        public object SDATE { get; set; }
        public string ACTUALSYI { get; set; }
        public string NAVTYPE { get; set; }
        public string JZZZL { get; set; }
        public string SGZT { get; set; }
        public string SHZT { get; set; }
        public string FHFCZ { get; set; }
        public string FHFCBZ { get; set; }
        public object DTYPE { get; set; }
        public string FHSP { get; set; }
    }

    public class Data
    {
        public IList<LSJZList> LSJZList { get; set; }
        public string FundType { get; set; }
        public object SYType { get; set; }
        public bool isNewType { get; set; }
        public string Feature { get; set; }
    }

    public class FundData
    {
        public Data Data { get; set; }
        public int ErrCode { get; set; }
        public object ErrMsg { get; set; }
        public int TotalCount { get; set; }
        public object Expansion { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
    }
}
