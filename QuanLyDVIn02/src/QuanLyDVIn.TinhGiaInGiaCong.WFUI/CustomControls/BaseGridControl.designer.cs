namespace ERP.Client
{
    partial class BaseGridControl
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
            this.SuspendLayout();
            // 
            // BaseGridControl
            // 
            this.Name = "BaseGridControl";
            this.Size = new System.Drawing.Size(458, 347);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadVirtualGrid radGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadButton editButton;
        private Telerik.WinControls.UI.RadButton deleteButton;
        private Telerik.WinControls.UI.RadButton printButton;
        private Telerik.WinControls.UI.RadButton exportButton;
    }
}
