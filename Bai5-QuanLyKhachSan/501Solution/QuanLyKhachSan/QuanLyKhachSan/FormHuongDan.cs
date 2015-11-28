using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class FormHuongDan : Form
    {
        public FormHuongDan()
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
            if (treeView1.SelectedNode.Name == "GT_SP")
            {
                str = Application.StartupPath + "\\Huong Dan\\San Pham.mht";
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
            if (treeView1.SelectedNode.Name == "HD_Phong")
            {
                str = Application.StartupPath + "\\Huong Dan\\Phong.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_DV")
            {
                str = Application.StartupPath + "\\Huong Dan\\Dich Vu.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_TTB")
            {
                str = Application.StartupPath + "\\Huong Dan\\Trang Thiet Bi.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_QLDV")
            {
                str = Application.StartupPath + "\\Huong Dan\\Quan Ly Dich Vu.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_QLP")
            {
                str = Application.StartupPath + "\\Huong Dan\\Quan Ly Phong.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_QLTTB")
            {
                str = Application.StartupPath + "\\Huong Dan\\Quan Ly TTB.mht";
                webBrowser1.Navigate(str);
            }
        }
    }
}
