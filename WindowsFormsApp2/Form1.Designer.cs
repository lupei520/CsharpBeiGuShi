namespace WindowsFormsApp2
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
            this.User_Text = new System.Windows.Forms.TextBox();
            this.FanKuiZhi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GuShi_XLH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GuShiName = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.JieGuo_LuRu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LuRuGuShi = new System.Windows.Forms.Button();
            this.ZhiLing_user = new System.Windows.Forms.TextBox();
            this.ZhiLing = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // User_Text
            // 
            this.User_Text.Location = new System.Drawing.Point(330, 79);
            this.User_Text.Multiline = true;
            this.User_Text.Name = "User_Text";
            this.User_Text.Size = new System.Drawing.Size(311, 101);
            this.User_Text.TabIndex = 0;
            // 
            // FanKuiZhi
            // 
            this.FanKuiZhi.Location = new System.Drawing.Point(381, 221);
            this.FanKuiZhi.Multiline = true;
            this.FanKuiZhi.Name = "FanKuiZhi";
            this.FanKuiZhi.Size = new System.Drawing.Size(208, 61);
            this.FanKuiZhi.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 13F);
            this.button1.Location = new System.Drawing.Point(412, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "提交默写";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuShi_XLH
            // 
            this.GuShi_XLH.Location = new System.Drawing.Point(444, 30);
            this.GuShi_XLH.Multiline = true;
            this.GuShi_XLH.Name = "GuShi_XLH";
            this.GuShi_XLH.Size = new System.Drawing.Size(85, 41);
            this.GuShi_XLH.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "输入古诗序列号:";
            // 
            // GuShiName
            // 
            this.GuShiName.AutoSize = true;
            this.GuShiName.Font = new System.Drawing.Font("宋体", 15F);
            this.GuShiName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.GuShiName.Location = new System.Drawing.Point(128, 114);
            this.GuShiName.Name = "GuShiName";
            this.GuShiName.Size = new System.Drawing.Size(119, 20);
            this.GuShiName.TabIndex = 5;
            this.GuShiName.Text = "请默写古诗:";
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(545, 30);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(111, 41);
            this.s.TabIndex = 6;
            this.s.Text = "选择古诗";
            this.s.UseVisualStyleBackColor = true;
            this.s.Click += new System.EventHandler(this.s_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(852, 67);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 33);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(852, 118);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 128);
            this.textBox2.TabIndex = 8;
            // 
            // JieGuo_LuRu
            // 
            this.JieGuo_LuRu.Location = new System.Drawing.Point(804, 287);
            this.JieGuo_LuRu.Multiline = true;
            this.JieGuo_LuRu.Name = "JieGuo_LuRu";
            this.JieGuo_LuRu.Size = new System.Drawing.Size(148, 82);
            this.JieGuo_LuRu.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(705, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "录入古诗的标题:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13F);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(884, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "录入古诗系统";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.ForeColor = System.Drawing.Color.BurlyWood;
            this.label4.Location = new System.Drawing.Point(705, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "录入古诗的内容:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label5.Location = new System.Drawing.Point(683, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "录入的结果:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(485, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "默写古诗系统";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.ForeColor = System.Drawing.Color.Coral;
            this.label7.Location = new System.Drawing.Point(243, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "默写结果:";
            // 
            // LuRuGuShi
            // 
            this.LuRuGuShi.Font = new System.Drawing.Font("宋体", 15F);
            this.LuRuGuShi.ForeColor = System.Drawing.Color.Red;
            this.LuRuGuShi.Location = new System.Drawing.Point(804, 390);
            this.LuRuGuShi.Name = "LuRuGuShi";
            this.LuRuGuShi.Size = new System.Drawing.Size(148, 60);
            this.LuRuGuShi.TabIndex = 16;
            this.LuRuGuShi.Text = "一键录入古诗";
            this.LuRuGuShi.UseVisualStyleBackColor = true;
            this.LuRuGuShi.Click += new System.EventHandler(this.LuRuGuShi_Click);
            // 
            // ZhiLing_user
            // 
            this.ZhiLing_user.Location = new System.Drawing.Point(970, 287);
            this.ZhiLing_user.Multiline = true;
            this.ZhiLing_user.Name = "ZhiLing_user";
            this.ZhiLing_user.Size = new System.Drawing.Size(121, 82);
            this.ZhiLing_user.TabIndex = 17;
            // 
            // ZhiLing
            // 
            this.ZhiLing.Font = new System.Drawing.Font("宋体", 12F);
            this.ZhiLing.ForeColor = System.Drawing.Color.Coral;
            this.ZhiLing.Location = new System.Drawing.Point(981, 390);
            this.ZhiLing.Name = "ZhiLing";
            this.ZhiLing.Size = new System.Drawing.Size(105, 59);
            this.ZhiLing.TabIndex = 18;
            this.ZhiLing.Text = "运行指令";
            this.ZhiLing.UseVisualStyleBackColor = true;
            this.ZhiLing.Click += new System.EventHandler(this.ZhiLing_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(24, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "作者：卢沛轩\r\nQQ号： 3028244575";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 523);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ZhiLing);
            this.Controls.Add(this.ZhiLing_user);
            this.Controls.Add(this.LuRuGuShi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JieGuo_LuRu);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.s);
            this.Controls.Add(this.GuShiName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuShi_XLH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FanKuiZhi);
            this.Controls.Add(this.User_Text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox User_Text;
        private System.Windows.Forms.TextBox FanKuiZhi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox GuShi_XLH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GuShiName;
        private System.Windows.Forms.Button s;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox JieGuo_LuRu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button LuRuGuShi;
        private System.Windows.Forms.TextBox ZhiLing_user;
        private System.Windows.Forms.Button ZhiLing;
        private System.Windows.Forms.Label label8;
    }
}

