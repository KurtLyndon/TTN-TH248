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
    public partial class PhieuMuon : Form
    {
        public PhieuMuon()
        {
            InitializeComponent();
        }

        private void PhieuMuon_Load(object sender, EventArgs e)
        {
            reset11();
            reset21();
            reset3();
        }

        private DataTable table1;
        private DataTable table2;
        private DataTable table3;
        private DataTable table4;
        private string IDstring;
        private string IDstring2;
        private Connection connector = new Connection();

        private void reset11()
        {
            listView1.Items.Clear();
            table1 = new DataTable();
            table1 = connector.LoadData("6");
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
            table1 = connector.FindObject("6", textSearch.Text.Trim());
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
            table2 = connector.LoadData("7");
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
            table2 = connector.FindObject("7", textSearch2.Text.Trim());
            int i = 0;
            foreach (DataRow row in table2.Rows)
            {
                listView2.Items.Add(row[0].ToString());
                listView2.Items[i].SubItems.Add(row[1].ToString());
                i++;
            }
        }

        private void reset3()
        {
            table3 = new DataTable();
            table3 = connector.LoadData("5");
            IDstring = "";
            foreach (DataRow row in table3.Rows)
            {
                IDstring = IDstring + row[0].ToString().Trim() + "/";
            }
            table4 = new DataTable();
            table4 = connector.LoadData("2");
            IDstring2 = "";
            foreach (DataRow row in table4.Rows)
            {
                IDstring2 = IDstring2 + row[0].ToString().Trim() + "/";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedItems[0].Index;
                textBCID1.Text = table1.Rows[index][0].ToString();
                textReaderID.Text = table1.Rows[index][1].ToString();
                textDate1.Text = table1.Rows[index][2].ToString().Substring(0, 11);
                textDate2.Text = table1.Rows[index][3].ToString().Substring(0, 11);
                textNote.Text = table1.Rows[index][4].ToString();
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                int index = listView2.SelectedItems[0].Index;
                textBCID2.Text = table2.Rows[index][0].ToString();
                textUnique.Text = table2.Rows[index][1].ToString();
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
                    textBCID1.ReadOnly = textReaderID.ReadOnly = textDate1.ReadOnly = textDate2.ReadOnly = textNote.ReadOnly = true;
                }
                else
                {
                    butFree.Enabled = true;
                    textBCID1.ReadOnly = true;
                    textReaderID.ReadOnly = textDate1.ReadOnly = textDate2.ReadOnly = textNote.ReadOnly = false;
                    if (rad.Text == "Add")
                    {
                        textBCID1.ReadOnly = false;
                        textBCID1.Text = textReaderID.Text = textDate1.Text = textDate2.Text = textNote.Text = "";
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
                    textBCID2.ReadOnly = textUnique.ReadOnly = true;
                }
                else
                {
                    butFree2.Enabled = true;
                    textBCID2.ReadOnly = true;
                    textUnique.ReadOnly = false;
                    if (rad.Text == "Add")
                    {
                        textBCID2.ReadOnly = false;
                        textBCID2.Text = textUnique.Text = "";
                    }
                }
            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                connector.DeleteObject("6", textBCID1.Text.Trim(), textReaderID.Text.Trim());
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
                connector.DeleteObject("7", textBCID2.Text.Trim(), textUnique.Text.Trim());
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
                if (textBCID1.Text.Trim() == "")
                {
                    MessageBox.Show("ID's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBCID1.Focus();
                    return false;
                }
                for (int i = 0; i < table1.Rows.Count; i++)
                {
                    if (textBCID1.Text.Trim() == table1.Rows[i][0].ToString().Trim())
                    {
                        MessageBox.Show("ID's values has been taken, please input new ID", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        textBCID1.Focus();
                        return false;
                    }
                }
            }
            if (textReaderID.Text.Trim() == "")
            {
                MessageBox.Show("Reader ID's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textReaderID.Focus();
                return false;
            }
            if (textDate1.Text.Trim() == "")
            {
                MessageBox.Show("Borrow date's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textDate1.Focus();
                return false;
            }
            if (textDate2.Text.Trim() == "")
            {
                MessageBox.Show("Return date's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textDate2.Focus();
                return false;
            }
            int p = 0;
            for (int i = 0; i < table3.Rows.Count; i++)
            {
                if (textReaderID.Text.Trim() == table3.Rows[i][0].ToString().Trim())
                {
                    p = 1;
                    break;
                }
            }
            if (p == 0)
            {
                MessageBox.Show("Reader ID's values must be in {" + IDstring + "}", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textReaderID.Focus();
                return false;
            }
            DateTime a;
            if (DateTime.TryParse(textDate1.Text, out a) == false)
            {
                MessageBox.Show("This date is not valid", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textDate1.Focus();
                return false;
            }
            if (DateTime.TryParse(textDate2.Text, out a) == false)
            {
                MessageBox.Show("This date is not valid", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textDate2.Focus();
                return false;
            }
            return true;
        }
        private bool check2(int k)
        {
            if (k == 1)
            {
                if (textBCID2.Text.Trim() == "")
                {
                    MessageBox.Show("ID's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBCID2.Focus();
                    return false;
                }
                for (int i = 0; i < table2.Rows.Count; i++)
                {
                    if (textBCID2.Text.Trim() == table2.Rows[i][0].ToString().Trim())
                    {
                        MessageBox.Show("ID's values has been taken, please input new ID", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        textBCID2.Focus();
                        return false;
                    }
                }
            }
            if (textUnique.Text.Trim() == "")
            {
                MessageBox.Show("Genre name's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textUnique.Focus();
                return false;
            }
            int p = 0;
            for (int i = 0; i < table4.Rows.Count; i++)
            {
                if (textUnique.Text.Trim() == table4.Rows[i][0].ToString().Trim())
                {
                    p = 1;
                    break;
                }
            }
            if (p == 0)
            {
                MessageBox.Show("Unique's values must be in {" + IDstring2 + "}", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textUnique.Focus();
                return false;
            }
            return true;
        }

        private void butFree_Click(object sender, EventArgs e)
        {
            if (butFree.Text == "Add")
            {
                if (check1(1) == false) return;
                connector.InsertUpdateObject("AddObject", "6", textBCID1.Text, textReaderID.Text, "", textNote.Text, "", "", textDate1.Text, textDate2.Text, "", "", "");
                MessageBox.Show("Inserting completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (check1(2) == false) return;
                connector.InsertUpdateObject("EditObject", "6", textBCID1.Text, textReaderID.Text, "", textNote.Text, "", "", textDate1.Text, textDate2.Text, "", "", "");
                MessageBox.Show("Updating completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reset11();
        }

        private void butFree2_Click(object sender, EventArgs e)
        {
            if (butFree2.Text == "Add")
            {
                if (check2(1) == false) return;
                connector.InsertUpdateObject("AddObject", "7", textBCID2.Text, textUnique.Text, "", "", "", "", "1/1/1994", "1/1/1994", "", "", "");
                MessageBox.Show("Inserting completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (check2(2) == false) return;
                connector.InsertUpdateObject("EditObject", "7", textBCID2.Text, textUnique.Text, "", "", "", "", "1/1/1994", "1/1/1994", "", "", "");
                MessageBox.Show("Updating completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reset21();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
