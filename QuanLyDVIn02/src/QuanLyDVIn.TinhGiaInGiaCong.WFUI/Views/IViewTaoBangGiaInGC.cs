using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDVIn.TinhGiaInGiaCong.WFUI.Views
{
    public interface IViewTaoBangGiaInGC
    {
        int Id { get; set; }
        string Ten { get; set; }
        string DienGiai { get; set; }
        string PhiCaiDatText { get; set; }
        string PhiHaoNVLCaiDatText { get; set; }
        string PhiToiThieuText { get; set; }
        string DaySoLuong { get; set; }
        string DayGia { get; set; }

        string DonViTinh { get; set; }
        string ThuTuText { get; set; }
        bool KhongSuDung { get; set; }
        string LoaiBangGia { get; set; }
        string SoLuongBaoText { get; set; }
    }
}
