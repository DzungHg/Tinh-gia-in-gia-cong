using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders.OpenXml.Xlsx;
using System.IO;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.WinForms.Spreadsheet;
using Telerik.Windows.Documents.Spreadsheet.FormatProviders;
using Telerik.WinControls;

namespace QuanLyDVIn.TinhGiaInGiaCong.WFUI
{
    public partial class BaseListViewControl : UserControl
    {
        protected List<string> columnNames;
        protected ISavableObject currentItem;
        protected Type[] columnTypes;
        protected string dataFormText; 
        public RadListView listView
        {
            get { return this.radListView1; }
        }

        public BaseListViewControl()
        {
            InitializeComponent();
            columnNames = new List<string>();
            this.radListView1.ViewType = ListViewType.DetailsView;
            
            this.Initialize();
        }

       

        


      
        protected virtual void Initialize()
        {

        }

        protected virtual void VirtualGridElement_PageIndexChanged(object sender, VirtualGridEventArgs e)
        {

        }

        protected virtual void radListView1_CellValueNeeded(object sender, VirtualGridCellValueNeededEventArgs e)
        {

        }

        protected virtual void EditButton_Click(object sender, EventArgs e)
        {
            if (this.listView.SelectedItem == null)
            {
                RadMessageBox.Show("Bạn vui lòng chọn một dòng.");
                return;
            }

           /* var dialog = new ERPDataForm();
            dialog.Text = dataFormText;
            dialog.DataEntry.DataSource = currentItem;
         
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentItem.Save(false);
                this.RefreshData(this.gridControl.PageSize * this.gridControl.PageIndex);
                
            }
            */
        }

        protected virtual void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.listView.SelectedItem == null)
            {
                RadMessageBox.Show("Bạn vui lòng chọn một dòng.");
                return;
            }

            if (RadMessageBox.Show("Delete Selected Item?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               // (currentItem as ISavableObject).Delete();
                
            }
        }

        protected virtual void PrintButton_Click(object sender, EventArgs e)
        {
         /*   if (this.listView.MasterViewInfo.IsWaiting)
            {
                RadMessageBox.Show("The Data is not loaded! Please wait!");
                return ;
            }

            var spreadsheet = new RadSpreadsheet();
            var window = new Form() { Width = 0, Height = 0, Opacity = 0 };
            spreadsheet.Parent = window;
            window.Show();
            spreadsheet.Workbook = CreateWorkbook();         
            //spreadsheet.Print(new PrintWhatSettings(ExportWhat.ActiveSheet, false));
            window.Close();*/
        }

        protected virtual void ExportButton_Click(object sender, EventArgs e)
        {
          /*  if (this.listView.MasterViewInfo.IsWaiting)
            {
                RadMessageBox.Show("The Data is not loaded! Please wait!");
                return ;
            }

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Document.xlsx";
            savefile.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                var formatProvider = new XlsxFormatProvider();

                using (Stream output = new FileStream(savefile.FileName, FileMode.Create))
                {
                    formatProvider.Export(CreateWorkbook(), output);
                }
            }
            */
        }

        protected virtual Workbook CreateWorkbook()
        {
            return new Workbook();
        }
        protected virtual void RefreshData(int skip)
        {

        }
    }
}
