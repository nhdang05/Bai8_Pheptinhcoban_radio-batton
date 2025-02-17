using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8_Pheptinhcoban_radio_batton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double so1 = double.Parse(txtSo1.Text);
            double so2 = double.Parse(txtSo2.Text);
            if (rdbCong.Checked)
            {
                txtKQ.Text = (so1 + so2).ToString();
            }
            if (rdbTru.Checked)
            {
                txtKQ.Text = (so1 - so2).ToString();
            }
            if (rdbNhan.Checked)
            {
                txtKQ.Text = (so1 * so2).ToString();
            }
            if (rdbChia.Checked)
            {
                if (so2 == 0)
                {
                    txtKQ.Text = "không chia được cho 0";
                }
                else
                {
                    txtKQ.Text = (so1 / so2).ToString();
                }
            }
        }
    }
}
