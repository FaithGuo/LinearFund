using EasyHttp.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinearFund
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fm.DataChange += Fm_DataChange;
        }

        private void Fm_DataChange(object sender, DataChangeEventArgs e)
        {
            var data = e.FundData;
            var fund = (FundManager)sender;
            labPageIndex.Text = "当前页:" + fund.PageIndex;
            labTotalCount.Text = "总页数:" + fund.TotalPage;
            this.Text = fm.FundName;
            if (!checkAdd.Checked)
            {
                listviewData.Items.Clear();
            }
            listviewData.BeginUpdate();
            foreach (var item in data.Data.LSJZList)
            {
                ListViewItem lvi = new ListViewItem(item.FSRQ);
                lvi.SubItems.Add(item.DWJZ);
                lvi.SubItems.Add(item.LJJZ);
                lvi.SubItems.Add(item.JZZZL + "%");
                lvi.SubItems.Add(item.SGZT);
                lvi.SubItems.Add(item.SHZT);
                listviewData.Items.Add(lvi);
            }
            listviewData.EndUpdate();

        }

        FundManager fm = new FundManager();

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime beginTimeResult = DateTime.MinValue;
            DateTime endTimeResult = DateTime.MinValue;
            if (!int.TryParse(txtCoder.Text, out int temp))
            {
                MessageBox.Show("基金代码为空或格式错误");
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtBeginTime.Text) && !DateTime.TryParse(txtBeginTime.Text, out beginTimeResult))
            {
                MessageBox.Show("开始时间格式错误");
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtEndTime.Text) && !DateTime.TryParse(txtEndTime.Text, out endTimeResult))
            {
                MessageBox.Show("结束时间格式错误");
                return;
            }
            fm.FundCode = txtCoder.Text;
            if (beginTimeResult != DateTime.MinValue)
                fm.BeginTime = beginTimeResult.ToString("yyyy-MM-dd");
            if (endTimeResult != DateTime.MinValue)
                fm.EndTime = endTimeResult.ToString("yyy-MM-dd");
            fm.FindFundName();
            fm.Get();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fm.GetNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fm.PageIndex -= 2;
            fm.GetNext();
        }
    }
}
