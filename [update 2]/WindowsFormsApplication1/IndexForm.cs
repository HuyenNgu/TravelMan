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
            this.btnTongCong.Click += btnTongCong_Click;
            //this.btnXemGiaTien.Click +=btnXemGiaTien_Click;
            InitializeComponent();
            
        }

        void btnTongCong_Click(object sender, EventArgs e)
        {
            var MaKhoiHanh = int.Parse(this.cbKhoiHanh.SelectedValue.ToString());
            var MaNoiDen = int.Parse(this.cbNoiDen.SelectedValue.ToString());
            var tongTien = this.Business.GetMoney(MaKhoiHanh,MaNoiDen);
            this.txtMoney.Text = tongTien.ToString();
        }

        void btnXemGiaTien_Click(object sender, EventArgs e)
        {
            var MoneyForm = new MoneyForm();
            MoneyForm.Show();
            this.Close();
        }
        private void LoadAll()
        {
            //var travel = this.Business.GetTravel();
            //this.grdTravel.DataSource = travel;
            var db = new testEntities();
            var travel = db.THONGTINKHACHHANGs.ToArray();
            this.grdTravel.DataSource = travel;

            var DiaDiem = db.ThongTinGiaTiens.ToArray();
            this.cbKhoiHanh.DataSource = DiaDiem;
            this.cbKhoiHanh.DisplayMember = "ten";
            this.cbKhoiHanh.ValueMember = "Id";

            var DiaDiemNoiDen = db.ThongTinGiaTiens.ToArray();
            this.cbNoiDen.DataSource = DiaDiemNoiDen;
            this.cbNoiDen.DisplayMember = "ten";
            this.cbNoiDen.ValueMember = "Id";
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

        private void btnInHoaDon_Click(object sender, EventArgs e)
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
                + "\nHo và Ten:\t\t" + txtHo.Text  + txtTenLot.Text  +  txtTen.Text             
                + "\nDia Chi:\t\t\t" + txtDiaChi.Text
                + "\nMa Vung:\t\t\t" + txtMaVung.Text
                + "\nSĐT:\t\t\t" + txtSDT.Text
                + "\nNoi Khoi Hanh:\t\t" + cbKhoiHanh.Text
                + "\nNoi Den:\t\t\t" + cbNoiDen.Text
                + "\nPhuong Tien:\t\t" + cbPhuongTien.Text
                + "\n----------------------------------------------------------------------------------------------------------------"
                + "\nTong cong:\t\t\t" + txtMoney.Text
                + "\n----------------------------------------------------------------------------------------------------------------"
                + "\n\n\t Cám ơn đã sử dụng bạn đã sử dụng hệ thống"
            );
        }

      

        private void rdbTietKiem_CheckedChanged(object sender, EventArgs e)
        {
            int valueinfo = 0;

            int count_int = 0;

            if (rdbTietKiem.Checked)
            {
                valueinfo = 5000;
                count_int = count_int + 5000;
               
            }
        }

        private void rdbThuong_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbThuong.Checked)
            {
                int valueinfo = 0;

                int count_int = 0;

                valueinfo = 10000;
                count_int = count_int + 10000;
                
            }
        }


        private void rdbThuongGia_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbThuongGia.Checked)
            {
                int valueinfo = 0;

                int count_int = 0;

                valueinfo = 15000;
                count_int = count_int + 15000;
                
            }
        }

    }
}
