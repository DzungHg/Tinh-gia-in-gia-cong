using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using QuanLyDVIn.TinhGiaInGiaCong.BDO;
using QuanLyDVIn.TinhGiaInGiaCong.Logic;

namespace QuanLyDVIn.TinhGiaInGiaCong.WFUI.Models
{
    public class NiemYetGIGCThanhPhamContext
    {
        NiemYetGiaInGiaCongThanhPhamLogic logic = new NiemYetGiaInGiaCongThanhPhamLogic();

        public  List<NiemYetGIGCThanhPham> DocTatCa()
        {
            

            var config = new MapperConfiguration(cfg => cfg.CreateMap<NiemYetGiaInGiaCongThanhPhamBDO, NiemYetGIGCThanhPham>());
            var mapper = config.CreateMapper();
            List<NiemYetGIGCThanhPham> nguon = mapper.Map<List<NiemYetGiaInGiaCongThanhPhamBDO>, List<NiemYetGIGCThanhPham>>(logic.DocTatCa());
            return nguon;
        }

        public  NiemYetGIGCThanhPham DocTheoId(int idBangGia)
        {
            

            var objBDO = logic.DocTheoId(idBangGia);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<NiemYetGiaInGiaCongThanhPhamBDO, NiemYetGIGCThanhPham>()
                        );
            var mapper = config.CreateMapper();

            var objModel = mapper.Map<NiemYetGIGCThanhPham>(objBDO);

            //Trả về
            return objModel;
        }


        public  string Them(NiemYetGIGCThanhPham bangGia)
        {
            
            var config = new MapperConfiguration(cfg => cfg.CreateMap<NiemYetGIGCThanhPham, NiemYetGiaInGiaCongThanhPhamBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map<NiemYetGiaInGiaCongThanhPhamBDO>(bangGia);

            //Thêm
            if (objBDO != null)
            {
                logic.Them(objBDO); //Thành công Mapper được
            }
            return "Đã thêm";
        }
        public  string Sua(NiemYetGIGCThanhPham bangGia)
        {
            
            var config = new MapperConfiguration(cfg => cfg.CreateMap<NiemYetGIGCThanhPham, NiemYetGiaInGiaCongThanhPhamBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map<NiemYetGiaInGiaCongThanhPhamBDO>(bangGia);
            logic.Sua(objBDO);

            return "Sửa xong";
        }
        
    }
}
