namespace Calculator2
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
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.op = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(59, 51);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 25);
            this.input1.TabIndex = 0;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(331, 51);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 25);
            this.input2.TabIndex = 1;
            // 
            // op
            // 
            this.op.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.op.FormattingEnabled = true;
            this.op.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.op.Location = new System.Drawing.Point(185, 53);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(121, 23);
            this.op.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(74, 221);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(67, 15);
            this.result.TabIndex = 4;
            this.result.Text = "计算结果";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 392);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.op);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.ComboBox op;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label result;
    }
}

