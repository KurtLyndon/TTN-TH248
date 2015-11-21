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
    public partial class FormQLDoDung : Form
    {
        public FormQLDoDung()
        {
            InitializeComponent();
        }

        private void FormQLDoDung_Load(object sender, EventArgs e)
        {
            reset();
            reset3();
        }

        private DataTable table1;
        private DataTable table2;
        private DataTable table3;
        private Connection connector = new Connection();

        private void reset()
        {
            listView1.Items.Clear();
            table1 = new DataTable();
            table1 = connector.LoadData("6");
            int i = 0;
            foreach (DataRow row in table1.Rows)
            {
                listView1.Items.Add(row[0].ToString());
                listView1.Items[i].SubItems.Add(row[1].ToString());
                listView1.Items[i].SubItems.Add(row[2].ToString());
                i++;
            }
        }

        private void reset2()
        {
            listView1.Items.Clear();
            table1 = connector.FindObject("6", textSearch.Text.Trim());
            int i = 0;
            foreach (DataRow row in table1.Rows)
            {
                listView1.Items.Add(row[0].ToString());
                listView1.Items[i].SubItems.Add(row[1].ToString());
                listView1.Items[i].SubItems.Add(row[2].ToString());
                i++;
            }
        }

        private void reset3()
        {
            listView2.Items.Clear();
            table2 = new DataTable();
            table2 = connector.LoadData("2");
            int i = 0;
            foreach (DataRow row in table2.Rows)
            {
                listView2.Items.Add(row[0].ToString());
                listView2.Items[i].SubItems.Add(row[1].ToString());
                i++;
            }
            listView3.Items.Clear();
            table3 = new DataTable();
            table3 = connector.LoadData("3");
            i = 0;
            foreach (DataRow row in table3.Rows)
            {
                listView3.Items.Add(row[0].ToString());
                listView3.Items[i].SubItems.Add(row[1].ToString());
                i++;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedItems[0].Index;
                textID1.Text = table1.Rows[index][0].ToString();
                textID2.Text = table1.Rows[index][1].ToString();
                textNum.Text = table1.Rows[index][2].ToString();
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                int index = listView2.SelectedItems[0].Index;
                textID1.Text = table2.Rows[index][0].ToString();
            }
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {
                int index = listView3.SelectedItems[0].Index;
                textID2.Text = table3.Rows[index][0].ToString();
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
                    textNum.ReadOnly = textID2.ReadOnly = textID1.ReadOnly = true;
                    listView2.Enabled = listView3.Enabled = false;
                }
                else
                {
                    butFree.Enabled = true;
                    textID1.ReadOnly = textID2.ReadOnly = true;
                    listView2.Enabled = listView3.Enabled = false;
                    textNum.ReadOnly = false;
                    if (rad.Text == "Add")
                    {
                        textID1.ReadOnly = textID2.ReadOnly = false;
                        textID1.Text = textID2.Text = textNum.Text = "";
                        listView2.Enabled = listView3.Enabled = true;
                    }
                }
            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                connector.DeleteObject("6", textID1.Text.Trim(), textID2.Text.Trim());
                if (butSearch.Text.Trim() == "Normal Mode")
                {
                    reset2();
                }
                else reset();
                textID1.Text = textID2.Text = textNum.Text = "";
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
            if (textID1.Text.Trim() == "")
            {
                MessageBox.Show("Room ID's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textID1.Focus();
                return false;
            }
            if (textID2.Text.Trim() == "")
            {
                MessageBox.Show("Item ID's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textID2.Focus();
                return false;
            }
            if (k == 1)
            {
                for (int i = 0; i < table1.Rows.Count; i++)
                {
                    if (textID1.Text.Trim() == table1.Rows[i][0].ToString().Trim() && textID2.Text.Trim() == table1.Rows[i][1].ToString().Trim())
                    {
                        MessageBox.Show("This room " + table1.Rows[i][0].ToString().Trim() + "already has this Item " + table1.Rows[i][1].ToString().Trim() + "broken or lost, please pick new pair", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        textID1.Focus();
                        return false;
                    }
                }
            }
            if (textNum.Text.Trim() == "")
            {
                MessageBox.Show("Number's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textNum.Focus();
                return false;
            }
            int b;
            if (int.TryParse(textNum.Text, out b) == false)
            {
                MessageBox.Show("This Number value is not valid", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textNum.Focus();
                return false;
            }
            return true;
        }

        private void butFree_Click(object sender, EventArgs e)
        {
            if (butFree.Text == "Add")
            {
                if (check(1) == false) return;
                connector.InsertUpdateObject("AddObject", "6", textID1.Text, textID2.Text, "", "1/1/1994", "1/1/1994", textNum.Text);
                MessageBox.Show("Inserting completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (check(2) == false) return;
                connector.InsertUpdateObject("EditObject", "6", textID1.Text, textID2.Text, "", "1/1/1994", "1/1/1994", textNum.Text);
                MessageBox.Show("Updating completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (butSearch.Text.Trim() == "Search Mode") reset();
            else reset2();
        }
    }
}
