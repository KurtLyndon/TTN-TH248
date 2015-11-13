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
    public partial class FormQLPhong : Form
    {
        public FormQLPhong()
        {
            InitializeComponent();
        }

        private void FormQLPhong_Load(object sender, EventArgs e)
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
            table1 = connector.LoadData("7");
            int i = 0;
            foreach (DataRow row in table1.Rows)
            {
                listView1.Items.Add(row[0].ToString());
                listView1.Items[i].SubItems.Add(row[1].ToString());
                listView1.Items[i].SubItems.Add(row[4].ToString());
                i++;
            }
        }

        private void reset2()
        {
            listView1.Items.Clear();
            table1 = connector.FindObject("7", textSearch.Text.Trim());
            int i = 0;
            foreach (DataRow row in table1.Rows)
            {
                listView1.Items.Add(row[0].ToString());
                listView1.Items[i].SubItems.Add(row[1].ToString());
                listView1.Items[i].SubItems.Add(row[4].ToString());
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
            table3 = connector.LoadData("1");
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
                textDate1.Text = table1.Rows[index][2].ToString().Substring(0, 11);
                textDate2.Text = table1.Rows[index][3].ToString().Substring(0, 11);
                textNum.Text = table1.Rows[index][4].ToString();
                textNote.Text = table1.Rows[index][5].ToString();
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
                    textDate1.ReadOnly = textDate2.ReadOnly = textNote.ReadOnly = textNum.ReadOnly = textID2.ReadOnly = textID1.ReadOnly = true;
                    listView2.Enabled = listView3.Enabled = false;
                }
                else
                {
                    butFree.Enabled = true;
                    textID1.ReadOnly = textID2.ReadOnly = true;
                    listView2.Enabled = listView3.Enabled = false;
                    textDate1.ReadOnly = textDate2.ReadOnly = textNote.ReadOnly = textNum.ReadOnly = false;
                    if (rad.Text == "Add")
                    {
                        textID1.ReadOnly = textID2.ReadOnly = false;
                        textID1.Text = textID2.Text = textDate1.Text = textDate2.Text = textNote.Text = textNum.Text = "";
                        listView2.Enabled = listView3.Enabled = true;
                    }
                }
            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                connector.DeleteObject("7", textID1.Text.Trim(), textID2.Text.Trim());
                if (butSearch.Text.Trim() == "Normal Mode")
                {
                    reset2();
                }
                else reset();
                textID1.Text = textID2.Text = textDate1.Text = textDate2.Text = textNote.Text = textNum.Text = "";
                MessageBox.Show("Deleting completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reset3();
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
                MessageBox.Show("Client ID's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textID2.Focus();
                return false;
            }
            if (k == 1)
            {
                for (int i = 0; i < table1.Rows.Count; i++)
                {
                    if (textID1.Text.Trim() == table1.Rows[i][0].ToString().Trim())
                    {
                        MessageBox.Show("This room " + table1.Rows[i][0].ToString().Trim() + "already has been rent, please pick new room", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            if (textDate1.Text.Trim() == "")
            {
                MessageBox.Show("Rent day's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textDate1.Focus();
                return false;
            }
            if (textDate2.Text.Trim() == "")
            {
                MessageBox.Show("Return day's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textDate2.Focus();
                return false;
            }
            int b;
            if (int.TryParse(textNum.Text, out b) == false)
            {
                MessageBox.Show("This Number value is not valid", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textNum.Focus();
                return false;
            }
            DateTime a;
            if (DateTime.TryParse(textDate1.Text, out a) == false)
            {
                MessageBox.Show("This day value is not valid", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textDate1.Focus();
                return false;
            }
            if (DateTime.TryParse(textDate2.Text, out a) == false)
            {
                MessageBox.Show("This day value is not valid", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textDate2.Focus();
                return false;
            }
            return true;
        }

        private void butFree_Click(object sender, EventArgs e)
        {
            if (butFree.Text == "Add")
            {
                if (check(1) == false) return;
                connector.InsertUpdateObject("AddObject", "7", textID1.Text, textID2.Text, textNote.Text, textDate1.Text, textDate2.Text, textNum.Text);
                MessageBox.Show("Inserting completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset3();
            }
            else
            {
                if (check(2) == false) return;
                connector.InsertUpdateObject("EditObject", "7", textID1.Text, textID2.Text, textNote.Text, textDate1.Text, textDate2.Text, textNum.Text);
                MessageBox.Show("Updating completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (butSearch.Text.Trim() == "Search Mode") reset();
            else reset2();
        }

        private void butAuto_Click(object sender, EventArgs e)
        {
            connector.Auto();
            if (butSearch.Text.Trim() == "Search Mode") reset();
            else reset2();
        }
    }
}
