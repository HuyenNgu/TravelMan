using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class TravelManagement
    {
        public THONGTINKHACHHANG[] GetTravel()
        {
            var db = new TRAVELMANAGEMENT2();
            var travel = db.THONGTINKHACHHANGs.ToArray();
            return travel;
        }
        public void AddTicket(string ID, string Họ, string Tên_đệm, string Tên, string Địa_chỉ,
            int Mã_vùng,string Số_Điện_Thoại,string Khởi_hành,string Nơi_đến,string Phương_Tiện,
            string Loại_vé,string Người_sử_dụng, int Số_lượng,int Tiền)
        {
            var newTravel = new THONGTINKHACHHANG();
            newTravel.ID = ID;
            newTravel.Họ = Họ;
            newTravel.Tên_đệm = Tên_đệm;
            newTravel.Tên = Tên;
            newTravel.Địa_chỉ = Địa_chỉ;
            newTravel.Mã_vùng = Mã_vùng;
            newTravel.Số_Điện_Thoại = Số_Điện_Thoại;
            newTravel.Khởi_hành = Khởi_hành;
            newTravel.Nơi_đến = Nơi_đến;
            newTravel.Phương_Tiện = Phương_Tiện;
            newTravel.Loại_vé = Loại_vé;
            newTravel.Người_sử_dụng = Người_sử_dụng;
            newTravel.Số_lượng = Số_lượng;
            newTravel.Tiền = Tiền;

            var db = new TRAVELMANAGEMENT2();
            db.THONGTINKHACHHANGs.Add(newTravel);
            db.SaveChanges();
        }

        public void EditTravel(int id,string ID, string Họ, string Tên_đệm, string Tên, string Địa_chỉ,
            int Mã_vùng, string Số_Điện_Thoại, string Khởi_hành, string Nơi_đến, string Phương_Tiện,
            string Loại_vé, string Người_sử_dụng, int Số_lượng, int Tiền)
        {
            var db = new TRAVELMANAGEMENT2();
            var oldTravel = db.THONGTINKHACHHANGs.Find(id);

            oldTravel.ID = ID;
            oldTravel.Họ = Họ;
            oldTravel.Tên_đệm = Tên_đệm;
            oldTravel.Tên = Tên;
            oldTravel.Địa_chỉ = Địa_chỉ;
            oldTravel.Mã_vùng = Mã_vùng;
            oldTravel.Số_Điện_Thoại = Số_Điện_Thoại;
            oldTravel.Khởi_hành = Khởi_hành;
            oldTravel.Nơi_đến = Nơi_đến;
            oldTravel.Phương_Tiện = Phương_Tiện;
            oldTravel.Loại_vé = Loại_vé;
            oldTravel.Người_sử_dụng = Người_sử_dụng;
            oldTravel.Số_lượng = Số_lượng;
            oldTravel.Tiền = Tiền;

            db.Entry(oldTravel).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteTicket(int id)
        {
            var db = new TRAVELMANAGEMENT2();
            var @travel = db.THONGTINKHACHHANGs.Find(id);
            db.THONGTINKHACHHANGs.Remove(@travel);
            db.SaveChanges();
        }

        public THONGTINKHACHHANG GetTravel(int id)
        {
            var db = new TRAVELMANAGEMENT2();
            var @class = db.THONGTINKHACHHANGs.Find(id);
            return @class;
        }
    }
}
