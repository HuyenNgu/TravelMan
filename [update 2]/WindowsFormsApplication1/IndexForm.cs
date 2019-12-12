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
            //this.btnXemGiaTien.Click +=btnXemGiaTien_Click;
            InitializeComponent();
        }

        //void btnXemGiaTien_Click(object sender, EventArgs e)
        //{
        //    var Money = new MoneyForm();
        //    Money.Show(this);
        //
        private void LoadAll()
        {
            var travel = this.Business.GetTravel();
            this.grdTravel.DataSource = travel;
        }

        void IndexForm_Load(object sender, EventArgs e)
        {
            this.LoadAll();
        }

    }
}
