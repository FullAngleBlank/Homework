namespace CrawlerUI
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
            this.panel_Relative = new System.Windows.Forms.Panel();
            this.button_RelativeCrawl = new System.Windows.Forms.Button();
            this.textBox_RelativeUrl = new System.Windows.Forms.TextBox();
            this.label_Relative2 = new System.Windows.Forms.Label();
            this.textBox_BaseUrl = new System.Windows.Forms.TextBox();
            this.label_Relative1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_AbsoluteUrl = new System.Windows.Forms.TextBox();
            this.button_AbsoluteCrawl = new System.Windows.Forms.Button();
            this.label_Absolute = new System.Windows.Forms.Label();
            this.panel_Relative.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Relative
            // 
            this.panel_Relative.Controls.Add(this.button_RelativeCrawl);
            this.panel_Relative.Controls.Add(this.textBox_RelativeUrl);
            this.panel_Relative.Controls.Add(this.label_Relative2);
            this.panel_Relative.Controls.Add(this.textBox_BaseUrl);
            this.panel_Relative.Controls.Add(this.label_Relative1);
            this.panel_Relative.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Relative.Location = new System.Drawing.Point(0, 0);
            this.panel_Relative.Name = "panel_Relative";
            this.panel_Relative.Size = new System.Drawing.Size(787, 136);
            this.panel_Relative.TabIndex = 0;
            // 
            // button_RelativeCrawl
            // 
            this.button_RelativeCrawl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_RelativeCrawl.Location = new System.Drawing.Point(679, 58);
            this.button_RelativeCrawl.Name = "button_RelativeCrawl";
            this.button_RelativeCrawl.Size = new System.Drawing.Size(75, 23);
            this.button_RelativeCrawl.TabIndex = 4;
            this.button_RelativeCrawl.Text = "爬取";
            this.button_RelativeCrawl.UseVisualStyleBackColor = true;
            this.button_RelativeCrawl.Click += new System.EventHandler(this.button_RelativeCrawl_Click);
            // 
            // textBox_RelativeUrl
            // 
            this.textBox_RelativeUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_RelativeUrl.Location = new System.Drawing.Point(391, 57);
            this.textBox_RelativeUrl.Name = "textBox_RelativeUrl";
            this.textBox_RelativeUrl.Size = new System.Drawing.Size(163, 25);
            this.textBox_RelativeUrl.TabIndex = 3;
            // 
            // label_Relative2
            // 
            this.label_Relative2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Relative2.AutoSize = true;
            this.label_Relative2.Location = new System.Drawing.Point(344, 13);
            this.label_Relative2.Name = "label_Relative2";
            this.label_Relative2.Size = new System.Drawing.Size(127, 15);
            this.label_Relative2.TabIndex = 2;
            this.label_Relative2.Text = "请输入相对地址：";
            // 
            // textBox_BaseUrl
            // 
            this.textBox_BaseUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_BaseUrl.Location = new System.Drawing.Point(64, 57);
            this.textBox_BaseUrl.Name = "textBox_BaseUrl";
            this.textBox_BaseUrl.Size = new System.Drawing.Size(156, 25);
            this.textBox_BaseUrl.TabIndex = 1;
            // 
            // label_Relative1
            // 
            this.label_Relative1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Relative1.AutoSize = true;
            this.label_Relative1.Location = new System.Drawing.Point(12, 9);
            this.label_Relative1.Name = "label_Relative1";
            this.label_Relative1.Size = new System.Drawing.Size(142, 15);
            this.label_Relative1.TabIndex = 0;
            this.label_Relative1.Text = "请输入相对地址基：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_AbsoluteUrl);
            this.panel1.Controls.Add(this.button_AbsoluteCrawl);
            this.panel1.Controls.Add(this.label_Absolute);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 148);
            this.panel1.TabIndex = 1;
            // 
            // textBox_AbsoluteUrl
            // 
            this.textBox_AbsoluteUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_AbsoluteUrl.Location = new System.Drawing.Point(64, 73);
            this.textBox_AbsoluteUrl.Name = "textBox_AbsoluteUrl";
            this.textBox_AbsoluteUrl.Size = new System.Drawing.Size(407, 25);
            this.textBox_AbsoluteUrl.TabIndex = 2;
            // 
            // button_AbsoluteCrawl
            // 
            this.button_AbsoluteCrawl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AbsoluteCrawl.Location = new System.Drawing.Point(679, 75);
            this.button_AbsoluteCrawl.Name = "button_AbsoluteCrawl";
            this.button_AbsoluteCrawl.Size = new System.Drawing.Size(75, 23);
            this.button_AbsoluteCrawl.TabIndex = 1;
            this.button_AbsoluteCrawl.Text = "爬取";
            this.button_AbsoluteCrawl.UseVisualStyleBackColor = true;
            this.button_AbsoluteCrawl.Click += new System.EventHandler(this.button_AbsoluteCrawl_Click);
            // 
            // label_Absolute
            // 
            this.label_Absolute.AutoSize = true;
            this.label_Absolute.Location = new System.Drawing.Point(12, 12);
            this.label_Absolute.Name = "label_Absolute";
            this.label_Absolute.Size = new System.Drawing.Size(127, 15);
            this.label_Absolute.TabIndex = 0;
            this.label_Absolute.Text = "请输入绝对地址：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 284);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Relative);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_Relative.ResumeLayout(false);
            this.panel_Relative.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Relative;
        private System.Windows.Forms.Button button_RelativeCrawl;
        private System.Windows.Forms.TextBox textBox_RelativeUrl;
        private System.Windows.Forms.Label label_Relative2;
        private System.Windows.Forms.TextBox textBox_BaseUrl;
        private System.Windows.Forms.Label label_Relative1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_AbsoluteUrl;
        private System.Windows.Forms.Button button_AbsoluteCrawl;
        private System.Windows.Forms.Label label_Absolute;
    }
}

