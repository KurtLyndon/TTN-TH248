using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
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
            if (treeView1.SelectedNode.Name == "root_GT_GTN")
            {
                str = Application.StartupPath + "\\Huong Dan\\Nhom thuc hien.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "root_GT_GTSP")
            {
                str = Application.StartupPath + "\\Huong Dan\\Gioi thieu san pham.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "root_HD_Chinh")
            {
                str = Application.StartupPath + "\\Huong Dan\\Form Chinh.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "root_HD_DA")
            {
                str = Application.StartupPath + "\\Huong Dan\\Form De An.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "root_HD_DV")
            {
                str = Application.StartupPath + "\\Huong Dan\\Form Don Vi.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "root_HD_NV")
            {
                str = Application.StartupPath + "\\Huong Dan\\Form Nhan Vien.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "root_HD_PC")
            {
                str = Application.StartupPath + "\\Huong Dan\\Form Phan Cong.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "root_HD_TN")
            {
                str = Application.StartupPath + "\\Huong Dan\\Form Than Nhan.mht";
                webBrowser1.Navigate(str);
            }
        }
    }
}
