using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ViewTTKH
    {
        public int Số_Thứ_Tự { get; set; }
        public string ID { get; set; }
        public string Họ { get; set; }
        public string Tên_lót { get; set; }
        public string Tên { get; set; }
        public string Địa_chỉ { get; set; }
        public Nullable<int> Mã_vùng { get; set; }
        public string Số_Điện_Thoại { get; set; }
        public string Khởi_hành { get; set; }
        public string Nơi_đến { get; set; }
        public string Phương_Tiện { get; set; }
        public string Loại_vé { get; set; }
        public string Người_sử_dụng { get; set; }
        public Nullable<int> Số_lượng { get; set; }
        public Nullable<int> Tiền { get; set; }
        public ViewTTKH(THONGTINKHACHHANG travel)
        {
            this.Số_Thứ_Tự = travel.Số_Thứ_Tự;
            this.ID = travel.ID;
            this.Họ = travel.Họ;
            this.Tên_lót = travel.Tên_lót;
            this.Tên = travel.Tên;
            this.Địa_chỉ = travel.Địa_chỉ;
            this.Mã_vùng = travel.Mã_vùng;
            this.Số_Điện_Thoại = travel.Số_Điện_Thoại;
            this.Khởi_hành = travel.Khởi_hành;
            this.Nơi_đến = travel.Nơi_đến;
            this.Phương_Tiện = travel.Phương_Tiện;
            this.Loại_vé = travel.Loại_vé;
            this.Phương_Tiện = travel.Phương_Tiện;
            this.Số_lượng = travel.Số_lượng;
            this.Tiền = travel.Tiền;
        }
    }
    
}
