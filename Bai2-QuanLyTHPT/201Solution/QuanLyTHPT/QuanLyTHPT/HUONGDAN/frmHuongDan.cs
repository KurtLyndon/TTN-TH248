using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTHPT.HUONGDAN
{
    public partial class frmHuongDan : Form
    {
        public frmHuongDan()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string str;
            if (treeView1.SelectedNode.Name == "GT_NTH")
            {
                str = Application.StartupPath + "\\Huong Dan\\Nhom thuc hien.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "GT_GTSP")
            {
                str = Application.StartupPath + "\\Huong Dan\\Gioi thieu san pham.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_QLC")
            {
                str = Application.StartupPath + "\\Huong Dan\\Quan Ly Chung.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_GV")
            {
                str = Application.StartupPath + "\\Huong Dan\\Giao Vien.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HV_HS")
            {
                str = Application.StartupPath + "\\Huong Dan\\Hoc Sinh.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_Lop")
            {
                str = Application.StartupPath + "\\Huong Dan\\Lop.mht";
                webBrowser1.Navigate(str);
            }
        }

    }
}
