
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Analytics;
using Telerik.WinControls.UI;


namespace QuanLyDVIn.TinhGiaInGiaCong.WFUI
{
    public partial class MainForm : ShapedForm
    {
        /* InfoControl infoControl;
         BaseGridControl storesControl;
         BaseGridControl vendorsControl;
         BaseGridControl purchasesControl;
         BaseGridControl inventoriesControl;
         BaseGridControl billOfMaterialsControl;
         BaseGridControl workOrdersControl;
         BaseGridControl individualsControl;
         BaseGridControl ordersControl;*/

        BaseListViewControl bangGiasControl;
        public MainForm()
        {
            //ControlTraceMonitor.AnalyticsMonitor = new GoogleAnalyticsMonitor();
            
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.radCollapsiblePanel2.CollapsiblePanelElement.HeaderElement.ShowHeaderLine = false;
            topControl1.ViewLabel.TextChanged += ViewLabel_TextChanged;
            //ThemeResolutionService.ApplicationThemeChanged += ThemeResolutionService_ApplicationThemeChanged;
            radTreeView2.SelectedNodeChanged += RadTreeView1_SelectedNodeChanged;
            radBreadCrumb2.DefaultTreeView = radTreeView2;

            //this.Icon = Resources.ERP;
            this.Text = "Tính giá in gia công";

            foreach (RadTreeNode item in radTreeView2.TreeViewElement.GetNodes())
            {
                if (item.Nodes.Count > 0)
                {
                    //item.Image = Resources.folder;
                }
            }
            topControl1.ViewLabel.Font = new Font("Segoe UI", 16, FontStyle.Regular);
            topControl1.ViewLabel.Text = "";
            radCollapsiblePanel2.EnableAnimation = false;
            radCollapsiblePanel2.Collapsed += RadCollapsiblePanel1_Collapsed;
            radCollapsiblePanel2.Expanded += RadCollapsiblePanel1_Expanded;
            
        }

        private void ViewLabel_TextChanged(object sender, EventArgs e)
        {
            radCollapsiblePanel2.HeaderText = "";//topControl1.ViewLabel.Text;
        }

        private void RadCollapsiblePanel1_Expanded(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnStyles[0].Width = 267;
        }

        private void RadCollapsiblePanel1_Collapsed(object sender, EventArgs e)
        {
            tableLayoutPanel1.ColumnStyles[0].Width = 40;
        }

        private void ThemeResolutionService_ApplicationThemeChanged(object sender, ThemeChangedEventArgs args)
        {
            OnThemeChanged();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            OnThemeChanged();
            radTreeView2.Nodes[0].Nodes[0].Selected = true;
            if (ControlTraceMonitor.AnalyticsMonitor != null)
            {
                ControlTraceMonitor.AnalyticsMonitor.TrackAtomicFeature("ApplicationStarted." + DateTime.Now.ToShortDateString());
            }
        }

        private void RadTreeView1_SelectedNodeChanged(object sender, Telerik.WinControls.UI.RadTreeViewEventArgs e)
        {
            if (ControlTraceMonitor.AnalyticsMonitor != null)
            {
                ControlTraceMonitor.AnalyticsMonitor.TrackAtomicFeature("ViewChanged." + e.Node.Name);
            }
            switch (e.Node.Name)
            {
                case "bangGiaInNode":
                    topControl1.ViewLabel.Text = "Bảng giá In";
                    AttachGridControl<BangGiaInGiaCongControl>(ref bangGiasControl);
                    break;
                    /*
                    case "instructionsNode":
                        topControl1.ViewLabel.Text = "Instructions";
                        AttachInfoControl("Instructions.pdf");
                        break;
                    case "documentationNode":
                        topControl1.ViewLabel.Text = "Documentation";
                        AttachInfoControl("Documentation.pdf");
                        break;
                    case "storesNode":
                        topControl1.ViewLabel.Text = "Stores";
                        AttachGridControl<StoresControl>(ref storesControl);
                        break;
                    case "suppliersNode":
                        topControl1.ViewLabel.Text = "Vendors";
                        AttachGridControl<VendorsControl>(ref vendorsControl);
                        break;
                    case "purchasesNode":
                        topControl1.ViewLabel.Text = "Purchase Orders";
                        AttachGridControl<PurchasesControl>(ref purchasesControl);
                        break;
                    case "productInventoryNode":
                        topControl1.ViewLabel.Text = "Product Inventory";
                        AttachGridControl<InventoriesControl>(ref inventoriesControl);
                        break;
                    case "billOfMaterialsNode":
                        topControl1.ViewLabel.Text = "Bill Of Materials";
                        AttachGridControl<BillOfMaterialsControl>(ref billOfMaterialsControl);
                        break;
                    case "workOrdersNode":
                        topControl1.ViewLabel.Text = "Work Orders";
                        AttachGridControl<WorkOrdersControl>(ref workOrdersControl);
                        break;
                    case "individualsNode":
                        topControl1.ViewLabel.Text = "Individuals";
                        AttachGridControl<IndividualsControl>(ref individualsControl);
                        break;
                    case "ordersNode":
                        topControl1.ViewLabel.Text = "Sales Orders";
                        AttachGridControl<OrdersControl>(ref ordersControl);
                        break;
                        */
            }
            
        }

        public void AttachGridControl<T>(ref BaseListViewControl ctrl) where T : BaseListViewControl, new()
        {
            if (ctrl == null)
            {
                ctrl = new T();
                ctrl.Dock = DockStyle.Fill;
                ctrl.Margin = new Padding(0, 0, 7, 7);
            }

            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 2));
            tableLayoutPanel1.Controls.Add(ctrl, 1, 2);

        }
        /*public void AttachInfoControl(string document)
        {
            if (infoControl == null)
            {
                infoControl = new InfoControl();
                infoControl.Dock = DockStyle.Fill;
                infoControl.Margin = new Padding(0, 0, 7, 7);
            }

            infoControl.InfoPdfViewer.LoadDocument(@"..\..\ERP.Client\Documents\" + document);
            infoControl.DocumentName = document;
           
            tableLayoutPanel1.Controls.Remove(tableLayoutPanel1.GetControlFromPosition(1, 2));
            tableLayoutPanel1.Controls.Add(infoControl, 1, 2);
        }*/

        protected void OnThemeChanged()
        {
            Theme theme = ThemeResolutionService.GetTheme(ThemeResolutionService.ApplicationThemeName);
       
            foreach (StyleGroup styleGroup in theme.StyleGroups)
            {
                foreach (PropertySettingGroup propertySettingGroup in styleGroup.PropertySettingGroups)
                {
                    if (propertySettingGroup.Selector.Value == "RadFormElement")
                    {
                        foreach (PropertySetting propertySetting in propertySettingGroup.PropertySettings)
                        {
                            if (propertySetting.Name == "BackColor")
                            {
                                this.BackColor = (Color)propertySetting.Value;
                                return;
                            }
                        }
                    }
                    if (styleGroup.Registrations[0].ControlType == "Telerik.WinControls.UI.RadForm" && propertySettingGroup.Selector.Value == "Telerik.WinControls.RootRadElement")
                    {
                        foreach (PropertySetting propertySetting in propertySettingGroup.PropertySettings)
                        {
                            if (propertySetting.Name == "BackColor")
                            {
                                this.BackColor = (Color)propertySetting.Value;
                                return;
                            }
                        }
                    }

                }

            }
        }
        
    }
}
