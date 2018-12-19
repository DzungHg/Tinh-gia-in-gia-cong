using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TinhGiaInGiaCong.BDO;

namespace QuanLyDVIn.TinhGiaInGiaCong.DAL
{
    public interface INiemYetGiaInGiaCongThanhPham
    {
        IEnumerable<NiemYetGiaInGiaCongThanhPhamBDO> DocTatCa();
        NiemYetGiaInGiaCongThanhPhamBDO DocTheoId(int iD);
        string Them(NiemYetGiaInGiaCongThanhPhamBDO entityBDO);
        string Sua(NiemYetGiaInGiaCongThanhPhamBDO entityBDO);
        string Xoa(int iD);
    }
}
