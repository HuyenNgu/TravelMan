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
    public partial class MoneyForm : Form
    {
        private TravelManagement Business;
        //IndexForm IDForm1;
        public MoneyForm(IndexForm IDForm)
        {
            this.Business = new TravelManagement();
            this.Load += MoneyForm_Load;
            //this.IDForm1 = IDForm;
            InitializeComponent();
        }

        void MoneyForm_Load(object sender, EventArgs e)
        {
            this.ShowDialog();
        }
        
    }
}
