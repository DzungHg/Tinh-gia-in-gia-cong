using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TinhGiaInGiaCong.BDO;
using QuanLyDVIn.TinhGiaInGiaCong.DAL;


namespace QuanLyDVIn.TinhGiaInGiaCong.Logic
{
    public class BangGiaInGiaCongLogic
    {
        BangGiaInGiaCongDAO dAO = new  BangGiaInGiaCongDAO();
        public List<BangGiaInGiaCongBDO> DocTatCa()
        {
            return dAO.DocTatCa().ToList();
        }
        public BangGiaInGiaCongBDO DocTheoId(int iD)
        {
            return dAO.DocTheoId(iD);
        }
        public string Them(BangGiaInGiaCongBDO entityBDO)
        {
            return dAO.Them(entityBDO);
        }
        public string Sua(BangGiaInGiaCongBDO entityBDO)
        {
            return dAO.Sua(entityBDO);
        }
        public string Xoa(int iD)
        {
            return dAO.Xoa(iD);
        }
    }
}
