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
    public partial class NXBTL : Form
    {
        public NXBTL()
        {
            InitializeComponent();
        }

        private void NXBTL_Load(object sender, EventArgs e)
        {
            reset11();
            reset21();
        }

        private DataTable table1;
        private DataTable table2;
        private Connection connector = new Connection();

        private void reset11()
        {
            listView1.Items.Clear();
            table1 = new DataTable();
            table1 = connector.LoadData("3");
            int i = 0;
            foreach (DataRow row in table1.Rows)
            {
                listView1.Items.Add(row[0].ToString());
                listView1.Items[i].SubItems.Add(row[1].ToString());
                i++;
            }
        }

        private void reset12()
        {
            listView1.Items.Clear();
            table1 = connector.FindObject("3", textSearch.Text.Trim());
            int i = 0;
            foreach (DataRow row in table1.Rows)
            {
                listView1.Items.Add(row[0].ToString());
                listView1.Items[i].SubItems.Add(row[1].ToString());
                i++;
            }
        }

        private void reset21()
        {
            listView2.Items.Clear();
            table2 = new DataTable();
            table2 = connector.LoadData("4");
            int i = 0;
            foreach (DataRow row in table2.Rows)
            {
                listView2.Items.Add(row[0].ToString());
                listView2.Items[i].SubItems.Add(row[1].ToString());
                i++;
            }
        }

        private void reset22()
        {
            listView2.Items.Clear();
            table2 = connector.FindObject("4", textSearch2.Text.Trim());
            int i = 0;
            foreach (DataRow row in table2.Rows)
            {
                listView2.Items.Add(row[0].ToString());
                listView2.Items[i].SubItems.Add(row[1].ToString());
                i++;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedItems[0].Index;
                textID1.Text = table1.Rows[index][0].ToString();
                textName1.Text = table1.Rows[index][1].ToString();
                textAddress.Text = table1.Rows[index][2].ToString();
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                int index = listView2.SelectedItems[0].Index;
                textID2.Text = table2.Rows[index][0].ToString();
                textName2.Text = table2.Rows[index][1].ToString();
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
                    textID1.ReadOnly = textName1.ReadOnly = textAddress.ReadOnly = true;
                }
                else
                {
                    butFree.Enabled = true;
                    textID1.ReadOnly = true;
                    textName1.ReadOnly = textAddress.ReadOnly = false;
                    if (rad.Text == "Add")
                    {
                        textID1.ReadOnly = false;
                        textID1.Text = textName1.Text = textAddress.Text = "";
                    }
                }
            }
        }

        private void radView2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = (RadioButton)(sender);
            if (rad.Checked == true)
            {
                butFree2.Text = rad.Text;
                if (rad.Text == "View")
                {
                    butFree2.Enabled = false;
                    textID2.ReadOnly = textName2.ReadOnly = true;
                }
                else
                {
                    butFree2.Enabled = true;
                    textID2.ReadOnly = true;
                    textName2.ReadOnly = false;
                    if (rad.Text == "Add")
                    {
                        textID2.ReadOnly = false;
                        textID2.Text = textName2.Text = "";
                    }
                }
            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                connector.DeleteObject("3", textID1.Text.Trim(), "");
                if (butSearch.Text.Trim() == "Search Mode")
                {
                    reset12();
                }
                else reset11();
                MessageBox.Show("Deleting completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butDel2_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                connector.DeleteObject("4", textID2.Text.Trim(), "");
                if (butSearch.Text.Trim() == "Search Mode")
                {
                    reset22();
                }
                else reset21();
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
                reset12();
            }
            else
            {
                butSearch.Text = "Search Mode";
                reset11();
            }
        }

        private void butSearch2_Click(object sender, EventArgs e)
        {
            if (butSearch2.Text.Trim() == "Search Mode")
            {
                if (textSearch2.Text.Trim() == "")
                {
                    MessageBox.Show("Text box is empty!", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textSearch2.Focus();
                    return;
                }
                butSearch2.Text = "Normal Mode";
                reset22();
            }
            else
            {
                butSearch2.Text = "Search Mode";
                reset21();
            }
        }

        private bool check1(int k)
        {
            if (k == 1)
            {
                if (textID1.Text.Trim() == "")
                {
                    MessageBox.Show("ID's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textID1.Focus();
                    return false;
                }
                for (int i = 0; i < table1.Rows.Count; i++)
                {
                    if (textID1.Text.Trim() == table1.Rows[i][0].ToString().Trim())
                    {
                        MessageBox.Show("ID's values has been taken, please input new ID", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        textID1.Focus();
                        return false;
                    }
                }
            }
            if (textName1.Text.Trim() == "")
            {
                MessageBox.Show("Publisher name's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textName1.Focus();
                return false;
            }
            if (textAddress.Text.Trim() == "")
            {
                MessageBox.Show("Address's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textAddress.Focus();
                return false;
            }
            return true;
        }
        private bool check2(int k)
        {
            if (k == 1)
            {
                if (textID2.Text.Trim() == "")
                {
                    MessageBox.Show("ID's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textID2.Focus();
                    return false;
                }
                for (int i = 0; i < table2.Rows.Count; i++)
                {
                    if (textID2.Text.Trim() == table2.Rows[i][0].ToString().Trim())
                    {
                        MessageBox.Show("ID's values has been taken, please input new ID", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        textID2.Focus();
                        return false;
                    }
                }
            }
            if (textName2.Text.Trim() == "")
            {
                MessageBox.Show("Genre name's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textName2.Focus();
                return false;
            }
            return true;
        }

        private void butFree_Click(object sender, EventArgs e)
        {
            if (butFree.Text == "Add")
            {
                if (check1(1) == false) return;
                connector.InsertUpdateObject("AddObject", "3", textID1.Text,"","",textName1.Text,textAddress.Text,"","1/1/1994","1/1/1994","","","");
                MessageBox.Show("Inserting completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (check1(2) == false) return;
                connector.InsertUpdateObject("EditObject", "3", textID1.Text, "", "", textName1.Text, textAddress.Text, "", "1/1/1994", "1/1/1994", "", "", "");
                MessageBox.Show("Updating completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reset11();
        }

        private void butFree2_Click(object sender, EventArgs e)
        {
            if (butFree2.Text == "Add")
            {
                if (check2(1) == false) return;
                connector.InsertUpdateObject("AddObject", "4", textID2.Text, "", "", textName2.Text, "", "", "1/1/1994", "1/1/1994", "", "", "");
                MessageBox.Show("Inserting completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (check2(2) == false) return;
                connector.InsertUpdateObject("EditObject", "4", textID2.Text, "", "", textName2.Text, "", "", "1/1/1994", "1/1/1994", "", "", "");
                MessageBox.Show("Updating completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reset21();
        }
    }
}
