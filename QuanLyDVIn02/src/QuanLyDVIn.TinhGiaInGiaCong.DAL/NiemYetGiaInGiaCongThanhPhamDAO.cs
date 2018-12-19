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
    public class NiemYetGiaInGiaCongThanhPhamDAO
    {
        string tenDB = "QuanLyGiaInDB";
        public IEnumerable<NiemYetGiaInGiaCongThanhPhamBDO> DocTatCa()
        {
            IEnumerable<NiemYetGiaInGiaCongThanhPhamBDO> output;
            //var str = GlobalConfig.CnnString(tenDB);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                output = connection.Query<NiemYetGiaInGiaCongThanhPhamBDO>("dbo.spNiemYetGiaInGiaCongThanhPham_DocTatCa");
                return output;
            }
        }


        public NiemYetGiaInGiaCongThanhPhamBDO DocTheoId(int iD)
        {
            NiemYetGiaInGiaCongThanhPhamBDO output = null;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters();
                p.Add("@id", iD);
                output = connection.QueryFirstOrDefault<NiemYetGiaInGiaCongThanhPhamBDO>("dbo.spNiemYetGiaInGiaCongThanhPham_DocTheoId", p, commandType: CommandType.StoredProcedure);//Thử              
                return output;
            }

        }
        #region them, sua, xoa
        public string Them(NiemYetGiaInGiaCongThanhPhamBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper

                p.Add("@Ten", entityBDO.Ten);
                p.Add("@DienGiai", entityBDO.DienGiai);
                p.Add("@IdBangGia", entityBDO.IdBangGia);
                p.Add("@IdHangKhachHang", entityBDO.IdHangKhachHang);
                p.Add("@ThuTu", entityBDO.ThuTu);
                p.Add("@KhongSuDung", entityBDO.KhongSuDung);
                p.Add("@LoaiThanhPham", entityBDO.LoaiThanhPham);

                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                //Excecute
                connection.Execute("dbo.spNiemYetGiaInGiaCongThanhPham_Them", p, commandType: CommandType.StoredProcedure);
                //xử lý id out
                entityBDO.Id = p.Get<int>("@id");
                ///nếu cần có thể
                ///đặt return ở đay cũng được
            }

            return "Đã thêm";
        }

        public string Sua(NiemYetGiaInGiaCongThanhPhamBDO entityBDO)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper
                p.Add("@id", entityBDO.Id);
                p.Add("@Ten", entityBDO.Ten);
                p.Add("@DienGiai", entityBDO.DienGiai);
                p.Add("@IdBangGia", entityBDO.IdBangGia);
                p.Add("@IdHangKhachHang", entityBDO.IdHangKhachHang);
                p.Add("@ThuTu", entityBDO.ThuTu);
                p.Add("@KhongSuDung", entityBDO.KhongSuDung);
                p.Add("@LoaiThanhPham", entityBDO.LoaiThanhPham);


                connection.Execute("dbo.spNiemYetGiaInGiaCongThanhPham_SuaTheoId", p, commandType: CommandType.StoredProcedure);

            }

            return $"Đã sửa {entityBDO.Id}";
        }

        public string Xoa(int iD)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(tenDB)))
            {
                var p = new DynamicParameters(); //Của dapper
                p.Add("@id", iD);


                connection.Execute("dbo.spNiemYetGiaInGiaCongThanhPham_XoaTheoId", p, commandType: CommandType.StoredProcedure);

            }

            return $"Đã sửa {iD}";
        }
        #endregion
    }
}
