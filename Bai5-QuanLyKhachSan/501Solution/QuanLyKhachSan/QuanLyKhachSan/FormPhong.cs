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
    public partial class FormPhong : Form
    {
        public FormPhong()
        {
            InitializeComponent();
        }

        private void FormPhong_Load(object sender, EventArgs e)
        {
            reset();
        }

        private DataTable table;
        private Connection connector = new Connection();

        private void reset()
        {
            listView1.Items.Clear();
            table = new DataTable();
            table = connector.LoadData("2");
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
            table = connector.FindObject("2", textSearch.Text.Trim());
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
                textState.Text = table.Rows[index][1].ToString();
                textCost.Text = table.Rows[index][2].ToString();
                textNote.Text = table.Rows[index][3].ToString();
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
                    textCost.ReadOnly = textState.ReadOnly = textID.ReadOnly = textNote.ReadOnly = true;
                }
                else
                {
                    butFree.Enabled = true;
                    textID.ReadOnly = true;
                    textCost.ReadOnly = textState.ReadOnly = textNote.ReadOnly = false;
                    if (rad.Text == "Add")
                    {
                        textID.ReadOnly = false;
                        textCost.Text = textState.Text = textID.Text = textNote.Text = "";
                    }
                }
            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                connector.DeleteObject("2", textID.Text.Trim(), "");
                if (butSearch.Text.Trim() == "Normal Mode")
                {
                    reset2();
                }
                else reset();
                textCost.Text = textState.Text = textID.Text = textNote.Text = "";
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
            if (textState.Text.Trim() == "")
            {
                MessageBox.Show("State's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textState.Focus();
                return false;
            }
            if (textCost.Text.Trim() == "")
            {
                MessageBox.Show("Cost's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textCost.Focus();
                return false;
            }
            int b;
            if (int.TryParse(textCost.Text, out b) == false)
            {
                MessageBox.Show("This Cost per day value is not valid", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textCost.Focus();
                return false;
            }
            if (textState.Text.Trim() != "Ready" && textState.Text.Trim()!="Busy")
            {
                MessageBox.Show("State's values must be [Busy,Ready] only", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textState.Focus();
                return false;
            }
            return true;
        }

        private void butFree_Click(object sender, EventArgs e)
        {
            if (butFree.Text == "Add")
            {
                if (check(1) == false) return;
                connector.InsertUpdateObject("AddObject", "2", textID.Text, textState.Text, textNote.Text, "1/1/1994", "1/1/1994", textCost.Text);
                MessageBox.Show("Inserting completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (check(2) == false) return;
                connector.InsertUpdateObject("EditObject", "2", textID.Text, textState.Text, textNote.Text, "1/1/1994", "1/1/1994", textCost.Text);
                MessageBox.Show("Updating completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (butSearch.Text.Trim() == "Search Mode") reset();
            else reset2();
        }
    }
}
