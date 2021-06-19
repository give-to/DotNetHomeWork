
namespace HomeWork10
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.chkType = new System.Windows.Forms.CheckBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSuccessUrl = new System.Windows.Forms.DataGridView();
            this.dgvFailUrl = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsUrl = new System.Windows.Forms.BindingSource(this.components);
            this.urlDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuccessUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFailUrl)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "是否只爬取html/aspx/jsp网页：";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.625F));
            this.tableLayoutPanel1.Controls.Add(this.lblURL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtURL, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAction, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 94);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblURL
            // 
            this.lblURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(3, 8);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(282, 15);
            this.lblURL.TabIndex = 0;
            this.lblURL.Text = "要爬取的URL:";
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(291, 3);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(500, 25);
            this.txtURL.TabIndex = 1;
            // 
            // chkType
            // 
            this.chkType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkType.AutoSize = true;
            this.chkType.Location = new System.Drawing.Point(291, 38);
            this.chkType.Name = "chkType";
            this.chkType.Size = new System.Drawing.Size(18, 17);
            this.chkType.TabIndex = 2;
            this.chkType.UseVisualStyleBackColor = true;
            // 
            // btnAction
            // 
            this.btnAction.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAction.Location = new System.Drawing.Point(652, 65);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(139, 26);
            this.btnAction.TabIndex = 4;
            this.btnAction.Text = "开始爬取";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgvSuccessUrl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvFailUrl, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 354F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 344);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // dgvSuccessUrl
            // 
            this.dgvSuccessUrl.AutoGenerateColumns = false;
            this.dgvSuccessUrl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuccessUrl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urlDataGridViewTextBoxColumn});
            this.dgvSuccessUrl.DataSource = this.bdsUrl;
            this.dgvSuccessUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuccessUrl.Location = new System.Drawing.Point(3, 3);
            this.dgvSuccessUrl.Name = "dgvSuccessUrl";
            this.dgvSuccessUrl.RowHeadersWidth = 51;
            this.dgvSuccessUrl.RowTemplate.Height = 27;
            this.dgvSuccessUrl.Size = new System.Drawing.Size(391, 338);
            this.dgvSuccessUrl.TabIndex = 0;
            // 
            // dgvFailUrl
            // 
            this.dgvFailUrl.AutoGenerateColumns = false;
            this.dgvFailUrl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFailUrl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urlDataGridViewTextBoxColumn1});
            this.dgvFailUrl.DataSource = this.bdsUrl;
            this.dgvFailUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFailUrl.Location = new System.Drawing.Point(400, 3);
            this.dgvFailUrl.Name = "dgvFailUrl";
            this.dgvFailUrl.RowHeadersWidth = 51;
            this.dgvFailUrl.RowTemplate.Height = 27;
            this.dgvFailUrl.Size = new System.Drawing.Size(391, 338);
            this.dgvFailUrl.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "爬取成功";
            this.urlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            // 
            // bdsUrl
            // 
            this.bdsUrl.DataSource = typeof(HomeWork10.MyURL);
            // 
            // urlDataGridViewTextBoxColumn1
            // 
            this.urlDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.urlDataGridViewTextBoxColumn1.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn1.HeaderText = "爬取失败";
            this.urlDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.urlDataGridViewTextBoxColumn1.Name = "urlDataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuccessUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFailUrl)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsUrl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.CheckBox chkType;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvSuccessUrl;
        private System.Windows.Forms.BindingSource bdsUrl;
        private System.Windows.Forms.DataGridView dgvFailUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

