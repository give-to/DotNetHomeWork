
namespace homework8
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreatOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnModifyOrder = new System.Windows.Forms.Button();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.btnExportOrder = new System.Windows.Forms.Button();
            this.btnImportOrder = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnCreatOrder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteOrder, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnModifyOrder, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSearchOrder, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnExportOrder, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnImportOrder, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCreatOrder
            // 
            this.btnCreatOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreatOrder.Location = new System.Drawing.Point(343, 23);
            this.btnCreatOrder.Name = "btnCreatOrder";
            this.btnCreatOrder.Size = new System.Drawing.Size(114, 28);
            this.btnCreatOrder.TabIndex = 0;
            this.btnCreatOrder.Text = "创建订单";
            this.btnCreatOrder.UseVisualStyleBackColor = true;
            this.btnCreatOrder.Click += new System.EventHandler(this.btnCreatOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteOrder.Location = new System.Drawing.Point(343, 97);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(114, 28);
            this.btnDeleteOrder.TabIndex = 1;
            this.btnDeleteOrder.Text = "删除订单";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnModifyOrder
            // 
            this.btnModifyOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModifyOrder.Location = new System.Drawing.Point(343, 170);
            this.btnModifyOrder.Name = "btnModifyOrder";
            this.btnModifyOrder.Size = new System.Drawing.Size(114, 30);
            this.btnModifyOrder.TabIndex = 2;
            this.btnModifyOrder.Text = "修改订单";
            this.btnModifyOrder.UseVisualStyleBackColor = true;
            this.btnModifyOrder.Click += new System.EventHandler(this.btnModifyOrder_Click);
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchOrder.Location = new System.Drawing.Point(343, 245);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(114, 28);
            this.btnSearchOrder.TabIndex = 3;
            this.btnSearchOrder.Text = "查询订单";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // btnExportOrder
            // 
            this.btnExportOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExportOrder.Location = new System.Drawing.Point(343, 319);
            this.btnExportOrder.Name = "btnExportOrder";
            this.btnExportOrder.Size = new System.Drawing.Size(114, 28);
            this.btnExportOrder.TabIndex = 4;
            this.btnExportOrder.Text = "导出订单";
            this.btnExportOrder.UseVisualStyleBackColor = true;
            this.btnExportOrder.Click += new System.EventHandler(this.btnExportOrder_Click);
            // 
            // btnImportOrder
            // 
            this.btnImportOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImportOrder.Location = new System.Drawing.Point(343, 396);
            this.btnImportOrder.Name = "btnImportOrder";
            this.btnImportOrder.Size = new System.Drawing.Size(114, 28);
            this.btnImportOrder.TabIndex = 5;
            this.btnImportOrder.Text = "导入订单";
            this.btnImportOrder.UseVisualStyleBackColor = true;
            this.btnImportOrder.Click += new System.EventHandler(this.btnImportOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCreatOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnModifyOrder;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.Button btnExportOrder;
        private System.Windows.Forms.Button btnImportOrder;
    }
}

