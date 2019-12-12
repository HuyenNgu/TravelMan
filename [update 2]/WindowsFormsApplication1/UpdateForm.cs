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
            this.Bussiness.EditTravel(this.TravelID, this.txtID, this.txtHo, this.txtTenLot, this.txtTen,
                this.txtDiaChi, this.txtMaVung, this.txtSDT, this.cbKhoiHanh, this.cbNoiDen, this.cbPhuongTien,
                this.rdbTietKiem, this.rdbThuong, this.rdbThuongGia, this.checkBox1, this.checkBox2,
                this.txtSoLuong, this.txtMoney);
            MessageBox.Show("successfully.");
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
