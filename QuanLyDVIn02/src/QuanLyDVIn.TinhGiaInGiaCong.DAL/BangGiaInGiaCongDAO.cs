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
    public class BangGiaInGiaCongDAO
    {
        string tenDB = "QuanLyGiaInDB";
        public IEnumerable<BangGiaInGiaCongBDO> DocTatCa()
        {
            IEnumerable<BangGiaInGiaCongBDO> output;
            //var str = GlobalConfig.CnnString(tenDB);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<BangGiaInGiaCongBDO>("dbo.spBangGiaInGiaCong_DocTatCa");
                return output;
            }
        }


        public BangGiaInGiaCongBDO DocTheoId(int iD)
        {
            BangGiaInGiaCongBDO output = null;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters();
                p.Add("@id", iD);
                output = connection.QueryFirstOrDefault<BangGiaInGiaCongBDO>("dbo.spBangGiaInGiaCong_DocTheoId", p, commandType: CommandType.StoredProcedure);//Thử              
                return output;
            }

        }
        #region them, sua, xoa
        public string Them(BangGiaInGiaCongBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper
               
                p.Add("@Ten", entityBDO.Ten);
                p.Add("@DienGiai", entityBDO.DienGiai);
                p.Add("@PhiCaiDat", entityBDO.PhiCaiDat);
                p.Add("@PhiHaoNVLCaiDat", entityBDO.PhiHaoNVLCaiDat);
                p.Add("@PhiToiThieu", entityBDO.PhiToiThieu);
                p.Add("@DaySoLuong", entityBDO.DaySoLuong);

                p.Add("@DayGia", entityBDO.DayGia);
                p.Add("@DonViTinh", entityBDO.DonViTinh);
                p.Add("@ThuTu", entityBDO.ThuTu);
                p.Add("@KhongSuDung", entityBDO.KhongSuDung);
                p.Add("@LoaiBangGia", entityBDO.LoaiBangGia);
                p.Add("@SoLuongBao", entityBDO.SoLuongBao);


                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                //Excecute
                connection.Execute("dbo.spBangGiaInGiaCong_Them", p, commandType: CommandType.StoredProcedure);
                //xử lý id out
                entityBDO.Id = p.Get<int>("@id");
                ///nếu cần có thể
                ///đặt return ở đay cũng được
            }

            return "Đã thêm";
        }

        public string Sua(BangGiaInGiaCongBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper
                p.Add("@id", entityBDO.Id);
                p.Add("@Ten", entityBDO.Ten);
                p.Add("@DienGiai", entityBDO.DienGiai);
                p.Add("@PhiCaiDat", entityBDO.PhiCaiDat);
                p.Add("@PhiHaoNVLCaiDat", entityBDO.PhiHaoNVLCaiDat);
                p.Add("@PhiToiThieu", entityBDO.PhiToiThieu);
                p.Add("@DaySoLuong", entityBDO.DaySoLuong);

                p.Add("@DayGia", entityBDO.DayGia);
                p.Add("@DonViTinh", entityBDO.DonViTinh);
                p.Add("@ThuTu", entityBDO.ThuTu);
                p.Add("@KhongSuDung", entityBDO.KhongSuDung);
                p.Add("@LoaiBangGia", entityBDO.LoaiBangGia);
                p.Add("@SoLuongBao", entityBDO.SoLuongBao);

                connection.Execute("dbo.spBangGiaInGiaCong_SuaTheoId", p, commandType: CommandType.StoredProcedure);

            }

            return $"Đã sửa {entityBDO.Id}";
        }

        public string Xoa(int iD)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper
                p.Add("@id", iD);


                connection.Execute("dbo.spBangGiaInGiaCong_XoaTheoId", p, commandType: CommandType.StoredProcedure);

            }

            return $"Đã sửa {iD}";
        }
        #endregion
    }
}
