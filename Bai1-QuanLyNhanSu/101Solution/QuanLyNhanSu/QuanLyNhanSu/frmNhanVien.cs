using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            reset();
            reset3();
        }

        private DataTable table;
        private DataTable table2;
        private string IDstring;
        private Connection connector = new Connection();

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
            DateTime a;
            if (DateTime.TryParse(textDoB.Text, out a) == false)
            {
                MessageBox.Show("This date of birth is not valid", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textDoB.Focus();
                return false;
            }
            if (textName.Text.Trim() == "")
            {
                MessageBox.Show("Name's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textName.Focus();
                return false;
            }
            if (textWork.Text.Trim() == "")
            {
                MessageBox.Show("Work's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textWork.Focus();
                return false;
            }
            int p = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (textManager.Text.Trim() != table.Rows[i][0].ToString().Trim())
                {
                    p++;
                    break;
                }
            }
            if (p == 0)
            {
                MessageBox.Show("ID manager value must be someone's ID", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textManager.Focus();
                return false;
            }
            int b;
            if (int.TryParse(textSalary.Text, out b) == false)
            {
                MessageBox.Show("This Salary's values is not valid", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textSalary.Focus();
                return false;
            }
            for (int i = 0; i < table2.Rows.Count; i++)
            {
                if (textWork.Text.Trim() == table2.Rows[i][1].ToString().Trim())
                {
                    MessageBox.Show("Workplace ID's values must be in {" + IDstring + "}", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textWork.Focus();
                    return false;
                }
            }
            return true;
        }

        private void reset()
        {
            listView1.Items.Clear();
            table = new DataTable();
            table = connector.LoadData("1");
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
            table = connector.FindObject("1", textSearch.Text.Trim());
            int i = 0;
            foreach (DataRow row in table.Rows)
            {
                listView1.Items.Add(row[0].ToString());
                listView1.Items[i].SubItems.Add(row[1].ToString());
                i++;
            }
        }

        private void reset3()
        {
            table2 = new DataTable();
            table2 = connector.LoadData("4");
            IDstring = "";
            foreach (DataRow row in table.Rows)
            {
                IDstring = IDstring + row[0].ToString().Trim() + "/";
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedItems[0].Index;
                textID.Text = table.Rows[index][0].ToString();
                textName.Text = table.Rows[index][1].ToString();
                textDoB.Text = table.Rows[index][2].ToString().Substring(0,11);
                if (table.Rows[index][3].ToString().Trim() == "Nam") radM.Checked = true;
                else radF.Checked = true;
                textAddress.Text = table.Rows[index][4].ToString();
                textSalary.Text = table.Rows[index][5].ToString();
                textWork.Text = table.Rows[index][6].ToString();
                textManager.Text = table.Rows[index][7].ToString();
            }
        }

        private void radView_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = (RadioButton)(sender);
            if (rad.Checked == true)
            {
                btnFree.Text = rad.Text;
                if (rad.Text == "View")
                {
                    btnFree.Enabled = false;
                    textDoB.ReadOnly = textName.ReadOnly = textID.ReadOnly = textManager.ReadOnly = textAddress.ReadOnly = textSalary.ReadOnly = textWork.ReadOnly = true;
                    radF.Enabled = radM.Enabled = false;
                }
                else
                {
                    btnFree.Enabled = true;
                    textID.ReadOnly = true;
                    textDoB.ReadOnly = textName.ReadOnly = textManager.ReadOnly = textAddress.ReadOnly = textSalary.ReadOnly = textWork.ReadOnly = false;
                    radF.Enabled = radM.Enabled = true;
                    if (rad.Text == "Add")
                    {
                        textID.ReadOnly = false;
                        textDoB.Text = textName.Text = textID.Text = textManager.Text = textAddress.Text = textSalary.Text = textWork.Text = "";
                        radM.Checked = true;
                    }
                }
            }
        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            if (btnFree.Text == "Add")
            {
                if (check(1) == false) return;
                string gt = "Nu";
                if (radM.Checked == true) gt = "Nam";
                connector.InsertUpdateObject("AddObject","1",textID.Text,textWork.Text,textManager.Text,textName.Text,textAddress.Text,textDoB.Text,gt,"",textSalary.Text,"");
                MessageBox.Show("Inserting completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (check(2) == false) return;
                string gt = "Nu";
                if (radM.Checked == true) gt = "Nam";
                connector.InsertUpdateObject("EditObject","1",textID.Text,textWork.Text,textManager.Text,textName.Text,textAddress.Text,textDoB.Text,gt,"",textSalary.Text,"");
                MessageBox.Show("Updating completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reset();
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                connector.DeleteObject("1", textID.Text.Trim(), "");
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void textWork_TextChanged(object sender, EventArgs e)
        {

        }

        private void textManager_TextChanged(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
