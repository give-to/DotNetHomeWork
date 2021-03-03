
namespace WindowsFormsApp1
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
            this.Operation = new System.Windows.Forms.ComboBox();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Operation
            // 
            this.Operation.Font = new System.Drawing.Font("宋体", 15F);
            this.Operation.FormattingEnabled = true;
            this.Operation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
            this.Operation.Location = new System.Drawing.Point(399, 143);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(48, 33);
            this.Operation.TabIndex = 0;
            this.Operation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Num1
            // 
            this.Num1.Font = new System.Drawing.Font("宋体", 15F);
            this.Num1.Location = new System.Drawing.Point(338, 141);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(45, 36);
            this.Num1.TabIndex = 1;
            this.Num1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Num2
            // 
            this.Num2.Font = new System.Drawing.Font("宋体", 15F);
            this.Num2.Location = new System.Drawing.Point(463, 141);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(49, 36);
            this.Num2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(518, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("宋体", 15F);
            this.Result.Location = new System.Drawing.Point(549, 143);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(55, 36);
            this.Result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Operation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Operation;
        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Result;
    }
}

