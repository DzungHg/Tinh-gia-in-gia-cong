using System.Collections.Generic;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace QuanLyDVIn.TinhGiaInGiaCong.WFUI.CustomControls
{
    public partial class TopControl : UserControl
    {
        Dictionary<string, bool> loadedThemes = new Dictionary<string, bool>();

        public RadLabel ViewLabel { get { return this.viewLabel; } }

        public TopControl()
        {
            InitializeComponent();

            

            InitializeThemesDropDown();
        }
        private void InitializeThemesDropDown()
        {
            


        }

        
    }
}
