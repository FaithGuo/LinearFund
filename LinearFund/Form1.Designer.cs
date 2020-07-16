namespace LinearFund
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listviewData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkAdd = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labTotalCount = new System.Windows.Forms.Label();
            this.labPageIndex = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBeginTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCoder = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listviewData
            // 
            this.listviewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listviewData.GridLines = true;
            this.listviewData.HideSelection = false;
            this.listviewData.Location = new System.Drawing.Point(12, 12);
            this.listviewData.Name = "listviewData";
            this.listviewData.Size = new System.Drawing.Size(924, 908);
            this.listviewData.TabIndex = 1;
            this.listviewData.UseCompatibleStateImageBehavior = false;
            this.listviewData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "净值日期";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "单位净值";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "累计净值";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "日增长率";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "申购状态";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "赎回状态";
            this.columnHeader6.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.checkAdd);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.labTotalCount);
            this.groupBox1.Controls.Add(this.labPageIndex);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEndTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBeginTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCoder);
            this.groupBox1.Location = new System.Drawing.Point(942, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 307);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "属性设置";
            // 
            // checkAdd
            // 
            this.checkAdd.AutoSize = true;
            this.checkAdd.Location = new System.Drawing.Point(9, 165);
            this.checkAdd.Name = "checkAdd";
            this.checkAdd.Size = new System.Drawing.Size(142, 22);
            this.checkAdd.TabIndex = 11;
            this.checkAdd.Text = "数据列表累加";
            this.checkAdd.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(149, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 39);
            this.button4.TabIndex = 10;
            this.button4.Text = "下一页";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(149, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 39);
            this.button3.TabIndex = 9;
            this.button3.Text = "上一页";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labTotalCount
            // 
            this.labTotalCount.AutoSize = true;
            this.labTotalCount.Location = new System.Drawing.Point(6, 256);
            this.labTotalCount.Name = "labTotalCount";
            this.labTotalCount.Size = new System.Drawing.Size(71, 18);
            this.labTotalCount.TabIndex = 8;
            this.labTotalCount.Text = "总页数:";
            // 
            // labPageIndex
            // 
            this.labPageIndex.AutoSize = true;
            this.labPageIndex.Location = new System.Drawing.Point(6, 211);
            this.labPageIndex.Name = "labPageIndex";
            this.labPageIndex.Size = new System.Drawing.Size(71, 18);
            this.labPageIndex.TabIndex = 7;
            this.labPageIndex.Text = "当前页:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "搜索";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "结束日期:";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(101, 121);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(163, 28);
            this.txtEndTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "开始日期:";
            // 
            // txtBeginTime
            // 
            this.txtBeginTime.Location = new System.Drawing.Point(101, 74);
            this.txtBeginTime.Name = "txtBeginTime";
            this.txtBeginTime.Size = new System.Drawing.Size(163, 28);
            this.txtBeginTime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "基金代码:";
            // 
            // txtCoder
            // 
            this.txtCoder.Location = new System.Drawing.Point(101, 27);
            this.txtCoder.Name = "txtCoder";
            this.txtCoder.Size = new System.Drawing.Size(163, 28);
            this.txtCoder.TabIndex = 0;
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 932);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listviewData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listviewData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkAdd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labTotalCount;
        private System.Windows.Forms.Label labPageIndex;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBeginTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCoder;
    }
}

