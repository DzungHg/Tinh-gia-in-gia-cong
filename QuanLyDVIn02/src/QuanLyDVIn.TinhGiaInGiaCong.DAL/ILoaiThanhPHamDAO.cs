using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDVIn.TinhGiaInGiaCong.BDO;

namespace QuanLyDVIn.TinhGiaInGiaCong.DAL
{
    public interface ILoaiThanhPhamDAO
    {
        IEnumerable<LoaiThanhPhamBDO> DocTatCa();
        LoaiThanhPhamBDO DocTheoId(int iD);
        
    }
}
