using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApplication
{
    public partial class FrmCompanyEditProfile : Form
    {
        public FrmCompanyEditProfile()
        {
            InitializeComponent();
        }

        //Method: update company information
        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }


        //Method: đóng windows này
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
