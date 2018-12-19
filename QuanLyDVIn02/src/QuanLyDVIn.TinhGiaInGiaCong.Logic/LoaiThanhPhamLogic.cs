using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TinhGiaInGiaCong.BDO;
using QuanLyDVIn.TinhGiaInGiaCong.DAL;


namespace QuanLyDVIn.TinhGiaInGiaCong.Logic
{
    public class LoaiThanhPhamLogic
    {
        LoaiThanhPhamDAO dAO = new  LoaiThanhPhamDAO();
        public List<LoaiThanhPhamBDO> DocTatCa()
        {
            return dAO.DocTatCa().ToList();
        }
        public LoaiThanhPhamBDO DocTheoId(int iD)
        {
            return dAO.DocTheoId(iD);
        }
       
    }
}
