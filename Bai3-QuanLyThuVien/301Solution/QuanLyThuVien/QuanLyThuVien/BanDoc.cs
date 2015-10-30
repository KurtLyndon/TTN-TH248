using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class BanDoc : Form
    {
        public BanDoc()
        {
            InitializeComponent();
        }

        private void BanDoc_Load(object sender, EventArgs e)
        {
            reset();
        }

        private DataTable table;
        private Connection connector = new Connection();

        private void reset()
        {
            listView1.Items.Clear();
            table = new DataTable();
            table = connector.LoadData("5");
            int i = 0;
            foreach (DataRow row in table.Rows)
            {
                listView1.Items.Add(row[0].ToString());
                listView1.Items[i].SubItems.Add(row[1].ToString());
                i++;
            }
        }

        private void reset2()
        {
            listView1.Items.Clear();
            table = connector.FindObject("5", textSearch.Text.Trim());
            int i = 0;
            foreach (DataRow row in table.Rows)
            {
                listView1.Items.Add(row[0].ToString());
                listView1.Items[i].SubItems.Add(row[1].ToString());
                i++;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedItems[0].Index;
                textID.Text = table.Rows[index][0].ToString();
                textName.Text = table.Rows[index][1].ToString();
                textDoB.Text = table.Rows[index][2].ToString().Substring(0, 11);
                if (table.Rows[index][3].ToString().Trim() == "Nam") radM.Checked = true;
                else radF.Checked = true;
                textPhone.Text = table.Rows[index][4].ToString();
                textHT.Text = table.Rows[index][5].ToString();
            }
        }

        private void radView_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = (RadioButton)(sender);
            if (rad.Checked == true)
            {
                butFree.Text = rad.Text;
                if (rad.Text == "View")
                {
                    butFree.Enabled = false;
                    textDoB.ReadOnly = textName.ReadOnly = textID.ReadOnly = textHT.ReadOnly = textPhone.ReadOnly = true;
                    radF.Enabled = radM.Enabled = false;
                }
                else
                {
                    butFree.Enabled = true;
                    textID.ReadOnly = true;
                    textDoB.ReadOnly = textName.ReadOnly = textHT.ReadOnly = textPhone.ReadOnly = false;
                    radF.Enabled = radM.Enabled = true;
                    if (rad.Text == "Add")
                    {
                        textID.ReadOnly = false;
                        textDoB.Text = textName.Text = textID.Text = textHT.Text = textPhone.Text = "";
                        radM.Checked = true;
                    }
                }
            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                connector.DeleteObject("5", textID.Text.Trim(), "");
                if (butSearch.Text.Trim() == "Search Mode")
                {
                    reset2();
                }
                else reset();
                MessageBox.Show("Deleting completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            if (butSearch.Text.Trim() == "Search Mode")
            {
                if (textSearch.Text.Trim() == "")
                {
                    MessageBox.Show("Text box is empty!", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textSearch.Focus();
                    return;
                }
                butSearch.Text = "Normal Mode";
                reset2();
            }
            else
            {
                butSearch.Text = "Search Mode";
                reset();
            }
        }

        private bool check(int k)
        {
            if (k == 1)
            {
                if (textID.Text.Trim() == "")
                {
                    MessageBox.Show("ID's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textID.Focus();
                    return false;
                }
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (textID.Text.Trim() == table.Rows[i][0].ToString().Trim())
                    {
                        MessageBox.Show("ID's values has been taken, please input new ID", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        textID.Focus();
                        return false;
                    }
                }
            }
            if (textName.Text.Trim() == "")
            {
                MessageBox.Show("Name's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textName.Focus();
                return false;
            }
            if (textDoB.Text.Trim() == "")
            {
                MessageBox.Show("Birth day's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textDoB.Focus();
                return false;
            }
            if (textPhone.Text.Trim() == "")
            {
                MessageBox.Show("Phone's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textPhone.Focus();
                return false;
            }
            if (textHT.Text.Trim() == "")
            {
                MessageBox.Show("Hometown's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textHT.Focus();
                return false;
            }
            DateTime a;
            if (DateTime.TryParse(textDoB.Text, out a) == false)
            {
                MessageBox.Show("This date of birth is not valid", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textDoB.Focus();
                return false;
            }
            int b;
            if (int.TryParse(textPhone.Text, out b) == false)
            {
                MessageBox.Show("This Phone number is not valid", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textPhone.Focus();
                return false;
            }
            return true;
        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            if (butFree.Text == "Add")
            {
                if (check(1) == false) return;
                string gt = "Nữ";
                if (radM.Checked == true) gt = "Nam";
                connector.InsertUpdateObject("AddObject", "5",textID.Text,"","",textName.Text,textHT.Text,gt,textDoB.Text,"1/1/1994",textPhone.Text,"","");
                MessageBox.Show("Inserting completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (check(2) == false) return;
                string gt = "Nữ";
                if (radM.Checked == true) gt = "Nam";
                connector.InsertUpdateObject("EditObject", "5", textID.Text, "", "", textName.Text, textHT.Text, gt, textDoB.Text, "1/1/1994", textPhone.Text, "", "");
                MessageBox.Show("Updating completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reset();
        }
    }
}
