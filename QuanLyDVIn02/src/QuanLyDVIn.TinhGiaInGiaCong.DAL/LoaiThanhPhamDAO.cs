using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using QuanLyDVIn.TinhGiaInGiaCong.BDO;
using QuanLyDVIn.TinhGiaInGiaCong.Common;



namespace QuanLyDVIn.TinhGiaInGiaCong.DAL
{
    public class LoaiThanhPhamDAO
    {
        string tenDB = "QuanLyGiaInDB";
        public IEnumerable<LoaiThanhPhamBDO> DocTatCa()
        {
            IEnumerable<LoaiThanhPhamBDO> output;
            //var str = GlobalConfig.CnnString(tenDB);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<LoaiThanhPhamBDO>("dbo.spLoaiThanhPham_DocTatCa");
                return output;
            }
        }


        public LoaiThanhPhamBDO DocTheoId(int iD)
        {
            LoaiThanhPhamBDO output = null;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters();
                p.Add("@id", iD);
                output = connection.QueryFirstOrDefault<LoaiThanhPhamBDO>("dbo.spLoaiThanhPham_DocTheoId", p, commandType: CommandType.StoredProcedure);//Thử              
                return output;
            }

        }
        
    }
}
