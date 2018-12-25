namespace QuanLyDVIn.TinhGiaInGiaCong.WFUI
{
    partial class BaseListViewControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.suaButton = new Telerik.WinControls.UI.RadButton();
            this.xoaButton = new Telerik.WinControls.UI.RadButton();
            this.exportButton = new Telerik.WinControls.UI.RadButton();
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.themButton = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suaButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xoaButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themButton)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.77229F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.66846F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.66906F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.22174F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.66846F));
            this.tableLayoutPanel1.Controls.Add(this.exportButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.radListView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.xoaButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.suaButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.themButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 562);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // suaButton
            // 
            this.suaButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.suaButton.Location = new System.Drawing.Point(103, 8);
            this.suaButton.Name = "suaButton";
            this.suaButton.Size = new System.Drawing.Size(93, 24);
            this.suaButton.TabIndex = 0;
            this.suaButton.Text = "Sửa";
            this.suaButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // xoaButton
            // 
            this.xoaButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.xoaButton.Location = new System.Drawing.Point(202, 8);
            this.xoaButton.Name = "xoaButton";
            this.xoaButton.Size = new System.Drawing.Size(93, 24);
            this.xoaButton.TabIndex = 1;
            this.xoaButton.Text = "Xóa";
            this.xoaButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.exportButton.Location = new System.Drawing.Point(686, 8);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(95, 24);
            this.exportButton.TabIndex = 3;
            this.exportButton.Text = "Export";
            this.exportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // radListView1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.radListView1, 5);
            this.radListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radListView1.Location = new System.Drawing.Point(3, 43);
            this.radListView1.Name = "radListView1";
            this.radListView1.Size = new System.Drawing.Size(778, 516);
            this.radListView1.TabIndex = 4;
            // 
            // themButton
            // 
            this.themButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.themButton.Location = new System.Drawing.Point(3, 8);
            this.themButton.Name = "themButton";
            this.themButton.Size = new System.Drawing.Size(94, 24);
            this.themButton.TabIndex = 2;
            this.themButton.Text = "Thêm";
            this.themButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // BaseListViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BaseListViewControl";
            this.Size = new System.Drawing.Size(784, 562);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.suaButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xoaButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadButton suaButton;
        private Telerik.WinControls.UI.RadButton xoaButton;
        private Telerik.WinControls.UI.RadButton exportButton;
        private Telerik.WinControls.UI.RadListView radListView1;
        private Telerik.WinControls.UI.RadButton themButton;
    }
}
