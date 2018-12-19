using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TinhGiaInGiaCong.BDO;
using QuanLyDVIn.TinhGiaInGiaCong.DAL;


namespace QuanLyDVIn.TinhGiaInGiaCong.Logic
{
    public class NiemYetGiaInGiaCongThanhPhamLogic
    {
        NiemYetGiaInGiaCongThanhPhamDAO dAO = new  NiemYetGiaInGiaCongThanhPhamDAO();
        public List<NiemYetGiaInGiaCongThanhPhamBDO> DocTatCa()
        {
            return dAO.DocTatCa().ToList();
        }
        public NiemYetGiaInGiaCongThanhPhamBDO DocTheoId(int iD)
        {
            return dAO.DocTheoId(iD);
        }
        public string Them(NiemYetGiaInGiaCongThanhPhamBDO entityBDO)
        {
            return dAO.Them(entityBDO);
        }
        public string Sua(NiemYetGiaInGiaCongThanhPhamBDO entityBDO)
        {
            return dAO.Sua(entityBDO);
        }
        public string Xoa(int iD)
        {
            return dAO.Xoa(iD);
        }
    }
}
