using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UpdateForm : Form
    {
        private int TravelID;
        private TravelManagement Bussiness;
        public UpdateForm(int id)
        {
            InitializeComponent();
            this.TravelID = id;
            this.Bussiness = new TravelManagement();
            this.btnThanhToan.Click += btnThanhToan_Click;
            this.Load += UpdateClassForm_Load;
        }

        void btnThanhToan_Click(object sender, EventArgs e)
        {
            var oldTravel = this.Bussiness.GetTravel(this.TravelID);
            this.txtID.Text = oldTravel.ID;
            this.txtHo.Text = oldTravel.Họ;
            this.txtTenLot.Text = oldTravel.Tên_đệm;
            this.txtTen.Text = oldTravel.Tên;
            this.txtDiaChi.Text = oldTravel.Địa_chỉ;
            this.txtMaVung.Text = Convert.ToString(oldTravel.Mã_vùng);
            this.txtSDT.Text = oldTravel.Số_Điện_Thoại;
            this.cbKhoiHanh.Text = oldTravel.Khởi_hành;
            this.cbNoiDen.Text = oldTravel.Nơi_đến;
            this.cbPhuongTien.Text = oldTravel.Phương_Tiện;
            this.rdbTietKiem.Text = oldTravel.Loại_vé;
            this.rdbThuong.Text = oldTravel.Loại_vé;
            this.rdbThuongGia.Text = oldTravel.Loại_vé;          
            this.checkBox1.Text = oldTravel.Người_sử_dụng;
            this.checkBox2.Text = oldTravel.Người_sử_dụng;
            this.txtSoLuong.Text = Convert.ToString(oldTravel.Số_lượng);
            this.txtMoney.Text = Convert.ToString(oldTravel.Tiền);
              public void EditTravel(int id,string ID, string Họ, string Tên_đệm, string Tên, string Địa_chỉ,
            int Mã_vùng, string Số_Điện_Thoại, string Khởi_hành, string Nơi_đến, string Phương_Tiện,
            string Loại_vé, string Người_sử_dụng, int Số_lượng, int Tiền)
        {
            this.Bussiness.EditTravel(this.TravelID, txtID.Text, txtHo.Text, txtTenLot.Text, txtTen.Text,
                txtDiaChi.Text, this.txtMaVung, txtSDT.Text, cbKhoiHanh.Text, cbNoiDen.Text, cbPhuongTien.Text,
                 this.txtSoLuong, this.txtMoney);
            MessageBox.Show("Update class successfully.");
        }

        void UpdateClassForm_Load(object sender, EventArgs e)
        {
            var oldTravel = this.Bussiness.GetTravel(this.TravelID);
            this.txtID.Text = oldTravel.ID;
            this.txtHo.Text = oldTravel.Họ;
            this.txtTenLot.Text = oldTravel.Tên_đệm;
            this.txtTen.Text = oldTravel.Tên;
            this.txtDiaChi.Text = oldTravel.Địa_chỉ;
            this.txtMaVung.Text = Convert.ToString(oldTravel.Mã_vùng);
            this.txtSDT.Text = oldTravel.Số_Điện_Thoại;
            this.cbKhoiHanh.Text = oldTravel.Khởi_hành;
            this.cbNoiDen.Text = oldTravel.Nơi_đến;
            this.cbPhuongTien.Text = oldTravel.Phương_Tiện;
            this.rdbThuong.Text = oldTravel.Loại_vé;
            this.txtID.Text = oldTravel.Người_sử_dụng;
            this.txtSoLuong.Text = Convert.ToString(oldTravel.Số_lượng);
            this.txtMoney.Text = Convert.ToString(oldTravel.Mã_vùng);

        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
