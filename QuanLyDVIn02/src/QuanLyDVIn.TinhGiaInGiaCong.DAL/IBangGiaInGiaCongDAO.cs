using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TinhGiaInGiaCong.BDO;

namespace QuanLyDVIn.TinhGiaInGiaCong.DAL
{
    public interface IBangGiaInGiaCongDAO
    {
        IEnumerable<BangGiaInGiaCongBDO> DocTatCa();
        BangGiaInGiaCongBDO DocTheoId(int iD);
        string Them(BangGiaInGiaCongBDO entityBDO);
        string Sua(BangGiaInGiaCongBDO entityBDO);
        string Xoa(int iD);
    }
}
