using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TinhGiaInGiaCong.WFUI.Models;
using QuanLyDVIn.TinhGiaInGiaCong.WFUI.Views;

namespace QuanLyDVIn.TinhGiaInGiaCong.WFUI.Presenters
{
    public class TaoBangGiaInGCPresenter
    {
        private IViewTaoBangGiaInGC View;

        public TaoBangGiaInGCPresenter(IViewTaoBangGiaInGC view)
        {
            View = view;
        }
    }
}
