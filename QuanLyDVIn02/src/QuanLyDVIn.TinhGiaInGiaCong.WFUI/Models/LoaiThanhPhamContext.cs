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
    public class LoaiThanhPhamContext
    {
        LoaiThanhPhamLogic logic = new LoaiThanhPhamLogic();

        public  List<LoaiThanhPham> DocTatCa()
        {
            

            var config = new MapperConfiguration(cfg => cfg.CreateMap<LoaiThanhPhamBDO, LoaiThanhPham>());
            var mapper = config.CreateMapper();
            List<LoaiThanhPham> nguon = mapper.Map<List<LoaiThanhPhamBDO>, List<LoaiThanhPham>>(logic.DocTatCa());
            return nguon;
        }

        public  LoaiThanhPham DocTheoId(int idBangGia)
        {
            

            var objBDO = logic.DocTheoId(idBangGia);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<LoaiThanhPhamBDO, LoaiThanhPham>()
                        );
            var mapper = config.CreateMapper();

            var objModel = mapper.Map<LoaiThanhPham>(objBDO);

            //Trả về
            return objModel;
        }


     
        
    }
}
