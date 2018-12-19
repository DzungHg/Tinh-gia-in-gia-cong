namespace ERP.Client
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radCollapsiblePanel2 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel2)).BeginInit();
            this.radCollapsiblePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.radTitleBar1.Name = "radTitleBar1";
            this.radTitleBar1.Size = new System.Drawing.Size(530, 23);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "ShapedForm";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.radCollapsiblePanel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(530, 291);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // radCollapsiblePanel2
            // 
            this.radCollapsiblePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radCollapsiblePanel2.Location = new System.Drawing.Point(2, 31);
            this.radCollapsiblePanel2.Name = "radCollapsiblePanel2";
            this.radCollapsiblePanel2.OwnerBoundsCache = new System.Drawing.Rectangle(2, 31, 119, 260);
            // 
            // radCollapsiblePanel2.PanelContainer
            // 
            this.radCollapsiblePanel2.PanelContainer.Size = new System.Drawing.Size(117, 258);
            this.radCollapsiblePanel2.Size = new System.Drawing.Size(119, 260);
            this.radCollapsiblePanel2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(530, 314);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.radTitleBar1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel2)).EndInit();
            this.radCollapsiblePanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TopControl topControl1;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel1;
        private Telerik.WinControls.UI.RadTreeView radTreeView1;
        private CustomControls.TitleBarControl titleBarControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadBreadCrumb radBreadCrumb1;
        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel2;
    }
}