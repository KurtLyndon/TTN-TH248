using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class frm_Start : Form
    {
        public frm_Start()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QUANLYSIEUTHI frmmain = new QUANLYSIEUTHI();
            frmmain.ShowDialog();
            this.Close() ;
        }
    }
}
