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
    public partial class IndexForm : Form
    {
        private int TravelID;
        private TravelManagement Business;
        public IndexForm()
        {
           
            this.Business = new TravelManagement();
            this.Load += IndexForm_Load;
            InitializeComponent();
        }

        private void btnXemGiaTien_Click(object sender, EventArgs e)
         {
             var MoneyForm = new MoneyForm();
             MoneyForm.ShowDialog();
             this.LoadAll();
        }

        private void LoadAll()
        {
            var travel = this.Business.GetTravel();
            this.grdTravel.DataSource = travel;
        }

        void IndexForm_Load(object sender, EventArgs e)
        {
            this.LoadAll();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rtReceipt.Clear();
            txtDiaChi.Clear();
            txtHo.Clear();
            txtID.Clear();
            txtMaVung.Clear();
            txtMoney.Clear();
            txtSDT.Clear();
            txtSoLuong.Clear();
            txtTen.Clear();
            txtTenLot.Clear();
            txtSoLuong.Clear();

            rdbThuong.Checked = false;
            rdbThuongGia.Checked = false;
            rdbTietKiem.Checked = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
        
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
            

            String ID = (txtID.Text);
            String Ho = (txtHo.Text);
            String TenLot = (txtTenLot.Text);
            String Ten = (txtTen.Text);
            String DiaChi = (txtDiaChi.Text);
            String MaVung = (txtMaVung.Text);
            String SDT = (txtSDT.Text);

            rtReceipt.AppendText("\t\tTravel Management System:\n"
               
                + "\n----------------------------------------------------------------------------------------------------------------"
                + "\nID:\t\t\t" + txtID.Text
                + "\nHọ và Tên: " + txtHo.Text  + txtTenLot.Text  +  txtTen.Text             
                + "\nĐịa Chỉ:\t\t\t" + txtDiaChi.Text
                + "\nMã Vùng:\t\t\t" + txtMaVung.Text
                + "\nSĐT:\t\t\t" + txtSDT.Text
                + "\nNơi Khởi Hành:\t\t" + cbKhoiHanh.Text
                + "\nNơi Đến:\t\t\t" + cbNoiDen.Text
                + "\nPhương Tiện:\t\t\t" + cbPhuongTien.Text
                + "\n----------------------------------------------------------------------------------------------------------------"
                + "\nTổng cộng:\t\t\t" + txtMoney.Text
                + "\n----------------------------------------------------------------------------------------------------------------"
                + "\n\n\t Cám ơn đã sử dụng bạn đã sử dụng hệ thống"
            );
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            DateTime Time = DateTime.Now;
            lblTime.Text = Time.ToLongTimeString();

            DateTime Date = DateTime.Now;
            lblDate.Text = Time.ToLongDateString();
        }

    }
}
