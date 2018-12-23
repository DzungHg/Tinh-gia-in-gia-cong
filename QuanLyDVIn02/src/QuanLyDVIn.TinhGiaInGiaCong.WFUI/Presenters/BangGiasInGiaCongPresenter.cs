using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TinhGiaInGiaCong.WFUI.Views;
using QuanLyDVIn.TinhGiaInGiaCong.WFUI.Models;

namespace QuanLyDVIn.TinhGiaInGiaCong.WFUI.Presenters
{
    public class BangGiasInGiaCongPresenter
    {
        private IViewBangGiasInGiaCong View;
        private BangGiaInGiaCongContext bangGiaContext = new BangGiaInGiaCongContext();
        public BangGiasInGiaCongPresenter(IViewBangGiasInGiaCong view)
        {
            View = view;
        }
        public List<BangGiaInGiaCong>BangGias()
        {
            return bangGiaContext.DocTatCa();
        }
    }
}
