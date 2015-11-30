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
    public partial class frmHuongDan : Form
    {
        public frmHuongDan()
        {
            InitializeComponent();
        }

        private void HUONGDAN_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string str;
            if (treeView1.SelectedNode.Name == "GT_NTH")
            {
                str = Application.StartupPath + "\\Huong Dan\\Nhom thuc hien.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "GT_SP")
            {
                str = Application.StartupPath + "\\Huong Dan\\Gioi thieu san pham.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_QLC")
            {
                str = Application.StartupPath + "\\Huong Dan\\Quan Ly Chung.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_KH")
            {
                str = Application.StartupPath + "\\Huong Dan\\Khach Hang.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_HH")
            {
                str = Application.StartupPath + "\\Huong Dan\\Hang Hoa.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_HD")
            {
                str = Application.StartupPath + "\\Huong Dan\\Hoa Don.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_NV")
            {
                str = Application.StartupPath + "\\Huong Dan\\Nhan Vien.mht";
                webBrowser1.Navigate(str);
            }
        }
    }
}
