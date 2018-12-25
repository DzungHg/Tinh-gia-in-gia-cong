using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using QuanLyDVIn.TinhGiaInGiaCong.WFUI.Views;
using QuanLyDVIn.TinhGiaInGiaCong.WFUI.Presenters;

namespace QuanLyDVIn.TinhGiaInGiaCong.WFUI
{ 

    public partial class BangGiaInGiaCongControl : BaseListViewControl, IViewBangGiasInGiaCong
    {
        /*public BangGiaInGiaCongControl()
        {
            InitializeComponent();

        }*/
        private BangGiasInGiaCongPresenter bangGiasPres;
        List<string> detailsViewColumnNames = new List<string>();

        public int IdBangGiaChon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected override void Initialize()
        {
            //Tạo bảng present
            bangGiasPres = new BangGiasInGiaCongPresenter(this);

            this.dataFormText = "Edit Purchase";
            
            columnTypes = new Type[] { typeof(string), typeof(DateTime), typeof(DateTime), typeof(decimal), typeof(decimal), typeof(decimal), typeof(decimal), typeof(DateTime), typeof(string), typeof(string) };

            this.columnNames.Add("Order Status");
            this.columnNames.Add("Order Date");
            this.columnNames.Add("Ship Date");
            this.columnNames.Add("Sub Total");
            this.columnNames.Add("Tax Amount");
            this.columnNames.Add("Freight");
            this.columnNames.Add("Total Due");
            this.columnNames.Add("Modified Date");
            this.columnNames.Add("Ship Method");
            this.columnNames.Add("Vendor");

            
            //Gắn data
            this.listView.DataSource = bangGiasPres.BangGias();

            this.detailsViewColumnNames.Add("Product");
            this.detailsViewColumnNames.Add("Quantity");
            this.detailsViewColumnNames.Add("Received Quantity");
            this.detailsViewColumnNames.Add("Rejected Quantity");
            this.detailsViewColumnNames.Add("Stocked Quantity");
            this.detailsViewColumnNames.Add("Price per Unit");
            this.detailsViewColumnNames.Add("Total Price");
            this.detailsViewColumnNames.Add("Due Date");
            this.detailsViewColumnNames.Add("Modified Date");

            /* this.gridControl.RowExpanding += GridControl_RowExpanding;
             this.gridControl.QueryHasChildRows += GridControl_QueryHasChildRows;
             this.gridControl.SelectionChanged += GridControl_SelectionChanged;

             this.gridControl.CellFormatting += GridControl_CellFormatting;
             this.gridControl.MasterViewInfo.SetColumnDataType(columnTypes);
             this.gridControl.RowFormatting += GridControl_RowFormatting;
             */
            this.listView.ColumnCreating += radListView_ColumnCreating;

        }
        private void radListView_ColumnCreating(object sender, ListViewColumnCreatingEventArgs e)
        {
            if (e.Column.FieldName == "Id")
                e.Column.Width = 20;
            if (e.Column.FieldName == "Ten")
            {
                e.Column.HeaderText = "Tên";
                e.Column.Width = 120;
            }

        }


        protected override void RefreshData(int skip)
        {
            //Gắn data
            this.listView.DataSource = null;
            this.listView.DataSource = bangGiasPres.BangGias();
        }

        protected override Workbook CreateWorkbook()
        {
            Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets.Add();

            // set header
            for (int i = 0; i < columnNames.Count; i++)
            {
                CellSelection selection = worksheet.Cells[0, i];
                selection.SetValue(columnNames[i]);
            }

            /*for (int i = 0; i < data.Count; i++)
            {
                int rowIndex = i + 1;
                CellSelection selection = worksheet.Cells[rowIndex, 0];
                selection.SetValue(data[i].OrderStatus);

                selection = worksheet.Cells[rowIndex, 1];
                selection.SetValue(data[i].OrderDate);

                selection = worksheet.Cells[rowIndex, 2];
                selection.SetValue(data[i].ShipDate.Value);

                selection = worksheet.Cells[rowIndex, 3];
                selection.SetValue(Convert.ToDouble(data[i].SubTotal));

                selection = worksheet.Cells[rowIndex, 4];
                selection.SetValue(Convert.ToDouble(data[i].TaxAmt));

                selection = worksheet.Cells[rowIndex, 5];
                selection.SetValue(Convert.ToDouble(data[i].Freight));

                selection = worksheet.Cells[rowIndex, 6];
                selection.SetValue(Convert.ToDouble(data[i].TotalDue));

                selection = worksheet.Cells[rowIndex, 7];
                selection.SetValue(data[i].ModifiedDate);

                selection = worksheet.Cells[rowIndex, 8];
                selection.SetValue(data[i].ShipMethod.Name);

                selection = worksheet.Cells[rowIndex, 9];
                selection.SetValue(data[i].Vendor.Name);

            }*/
            worksheet.Columns[worksheet.UsedCellRange].AutoFitWidth();
            worksheet.Name = "Purchases";
            return workbook;
        }
    }
}
