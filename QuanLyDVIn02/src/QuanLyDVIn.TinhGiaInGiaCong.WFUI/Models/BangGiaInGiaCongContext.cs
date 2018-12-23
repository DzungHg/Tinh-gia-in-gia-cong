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
    public class BangGiaInGiaCongContext
    {
        BangGiaInGiaCongLogic logic = new BangGiaInGiaCongLogic();

        public  List<BangGiaInGiaCong> DocTatCa()
        {
            

            var config = new MapperConfiguration(cfg => cfg.CreateMap<BangGiaInGiaCongBDO, BangGiaInGiaCong>());
            var mapper = config.CreateMapper();
            List<BangGiaInGiaCong> nguon = mapper.Map<List<BangGiaInGiaCongBDO>, List<BangGiaInGiaCong>>(logic.DocTatCa());
            return nguon;
        }

        public  BangGiaInGiaCong DocTheoId(int idBangGia)
        {
            

            var objBDO = logic.DocTheoId(idBangGia);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<BangGiaInGiaCongBDO, BangGiaInGiaCong>()
                        );
            var mapper = config.CreateMapper();

            var objModel = mapper.Map<BangGiaInGiaCong>(objBDO);

            //Trả về
            return objModel;
        }


        public  string Them(BangGiaInGiaCong bangGia)
        {
            
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BangGiaInGiaCong, BangGiaInGiaCongBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map<BangGiaInGiaCongBDO>(bangGia);

            //Thêm
            if (objBDO != null)
            {
                logic.Them(objBDO); //Thành công Mapper được
            }
            return "Đã thêm";
        }
        public  string Sua(BangGiaInGiaCong bangGia)
        {
            
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BangGiaInGiaCong, BangGiaInGiaCongBDO>());
            var mapper = config.CreateMapper();
            var objBDO = mapper.Map<BangGiaInGiaCongBDO>(bangGia);
            logic.Sua(objBDO);

            return "Sửa xong";
        }
        
    }
}
