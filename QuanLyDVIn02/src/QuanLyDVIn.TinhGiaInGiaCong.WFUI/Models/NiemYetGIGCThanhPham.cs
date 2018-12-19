using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDVIn.TinhGiaInGiaCong.WFUI.Models
{
    public class NiemYetGIGCThanhPham
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public string DienGiai { get; set; }
        public int IdBangGia { get; set; }
        public int IdHangKhachHang { get; set; }
        public int ThuTu { get; set; }
        public bool KhongSuDung { get; set; }      
        public string LoaiThanhPham { get; set; }//CONTS
        
    }
}
