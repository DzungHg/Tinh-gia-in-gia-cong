using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDVIn.TinhGiaInGiaCong.BDO
{
    public class BangGiaInGiaCongBDO
    {


        public int Id { get; set; }
        public string Ten { get; set; }
        public string DienGiai { get; set; }
        public int PhiCaiDat { get; set; }
        public int PhiHaoNVLCaiDat { get; set; }
        public int PhiToiThieu { get; set; }
        public string DaySoLuong { get; set; }
        public string DayGia { get; set; }

        public string DonViTinh { get; set; }
        public int ThuTu { get; set; }
        public bool KhongSuDung { get; set; }
        public string LoaiBangGia { get; set; }
        public int SoLuongBao { get; set; }
    }
}
