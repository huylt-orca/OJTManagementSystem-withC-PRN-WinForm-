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
    public partial class FrmCompanyEvaluateInterns : Form
    {
        public FrmCompanyEvaluateInterns()
        {
            InitializeComponent();
        }

        //Method: thực hiện cập nhật điểm và cập nhật evaluation
        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        //Method: thực hiện close frm hiện tại
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
