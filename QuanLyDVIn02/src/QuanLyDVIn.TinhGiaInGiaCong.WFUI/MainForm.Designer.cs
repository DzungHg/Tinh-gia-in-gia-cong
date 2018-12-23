namespace QuanLyDVIn.TinhGiaInGiaCong.WFUI
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
            Telerik.WinControls.UI.RadTreeNode radTreeNode1 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode2 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode3 = new Telerik.WinControls.UI.RadTreeNode();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radCollapsiblePanel2 = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.radTreeView2 = new Telerik.WinControls.UI.RadTreeView();
            this.radBreadCrumb2 = new Telerik.WinControls.UI.RadBreadCrumb();
            this.topControl1 = new QuanLyDVIn.TinhGiaInGiaCong.WFUI.TopControl();
            this.titleBarControl1 = new QuanLyDVIn.TinhGiaInGiaCong.WFUI.TitleBarControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel2)).BeginInit();
            this.radCollapsiblePanel2.PanelContainer.SuspendLayout();
            this.radCollapsiblePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBreadCrumb2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.radCollapsiblePanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radBreadCrumb2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.topControl1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(866, 546);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // radCollapsiblePanel2
            // 
            this.radCollapsiblePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radCollapsiblePanel2.ExpandDirection = Telerik.WinControls.UI.RadDirection.Right;
            this.radCollapsiblePanel2.Location = new System.Drawing.Point(10, 58);
            this.radCollapsiblePanel2.Margin = new System.Windows.Forms.Padding(10, 4, 7, 10);
            this.radCollapsiblePanel2.Name = "radCollapsiblePanel2";
            this.radCollapsiblePanel2.OwnerBoundsCache = new System.Drawing.Rectangle(2, 31, 119, 260);
            // 
            // radCollapsiblePanel2.PanelContainer
            // 
            this.radCollapsiblePanel2.PanelContainer.Controls.Add(this.radTreeView2);
            this.radCollapsiblePanel2.PanelContainer.Size = new System.Drawing.Size(151, 476);
            this.tableLayoutPanel1.SetRowSpan(this.radCollapsiblePanel2, 2);
            this.radCollapsiblePanel2.Size = new System.Drawing.Size(179, 478);
            this.radCollapsiblePanel2.TabIndex = 1;
            // 
            // radTreeView2
            // 
            this.radTreeView2.BackColor = System.Drawing.SystemColors.Control;
            this.radTreeView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.radTreeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTreeView2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radTreeView2.ForeColor = System.Drawing.Color.Black;
            this.radTreeView2.Location = new System.Drawing.Point(0, 0);
            this.radTreeView2.Name = "radTreeView2";
            radTreeNode1.Expanded = true;
            radTreeNode1.Name = "bangGiaNode";
            radTreeNode2.Name = "bangGiaInNode";
            radTreeNode2.Text = "Giá in";
            radTreeNode3.Expanded = true;
            radTreeNode3.Name = "Node3";
            radTreeNode3.Text = "Bảng giá cán phủ";
            radTreeNode1.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode2,
            radTreeNode3});
            radTreeNode1.Text = "Bảng giá";
            this.radTreeView2.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode1});
            this.radTreeView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radTreeView2.Size = new System.Drawing.Size(151, 476);
            this.radTreeView2.SpacingBetweenNodes = -1;
            this.radTreeView2.TabIndex = 0;
            // 
            // radBreadCrumb2
            // 
            this.radBreadCrumb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radBreadCrumb2.Location = new System.Drawing.Point(199, 57);
            this.radBreadCrumb2.Name = "radBreadCrumb2";
            this.radBreadCrumb2.Size = new System.Drawing.Size(664, 32);
            this.radBreadCrumb2.TabIndex = 1;
            this.radBreadCrumb2.Text = "radBreadCrumb2";
            // 
            // topControl1
            // 
            this.topControl1.Location = new System.Drawing.Point(199, 3);
            this.topControl1.Name = "topControl1";
            this.topControl1.Size = new System.Drawing.Size(664, 48);
            this.topControl1.TabIndex = 2;
            // 
            // titleBarControl1
            // 
            this.titleBarControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(54)))));
            this.titleBarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarControl1.Location = new System.Drawing.Point(0, 0);
            this.titleBarControl1.Name = "titleBarControl1";
            this.titleBarControl1.Size = new System.Drawing.Size(866, 31);
            this.titleBarControl1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(866, 577);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.titleBarControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.radCollapsiblePanel2.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radCollapsiblePanel2)).EndInit();
            this.radCollapsiblePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radBreadCrumb2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private TopControl topControl1;
       
       
       // private CustomControls.TitleBarControl titleBarControl1;
       
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadCollapsiblePanel radCollapsiblePanel2;
        private Telerik.WinControls.UI.RadTreeView radTreeView2;
        private Telerik.WinControls.UI.RadBreadCrumb radBreadCrumb2;
        private TopControl topControl1;
        private TitleBarControl titleBarControl1;
    }
}