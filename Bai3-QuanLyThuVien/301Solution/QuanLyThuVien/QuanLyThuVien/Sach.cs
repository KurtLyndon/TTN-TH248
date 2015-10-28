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
    public partial class Sach : Form
    {
        public Sach()
        {
            InitializeComponent();
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            reset11();
            reset21();
            reset3();
        }

        private DataTable table1;
        private DataTable table2;
        private DataTable table3;
        private DataTable table4;
        string IDstring1;
        string IDstring3;
        string IDstring4;
        private Connection connector = new Connection();

        private void reset11()
        {
            listView1.Items.Clear();
            table1 = new DataTable();
            table1 = connector.LoadData("1");
            int i = 0;
            foreach (DataRow row in table1.Rows)
            {
                listView1.Items.Add(row[0].ToString());
                listView1.Items[i].SubItems.Add(row[1].ToString());
                IDstring1 = IDstring1 + row[0].ToString().Trim()+"/";
                i++;
            }
        }

        private void reset12()
        {
            listView1.Items.Clear();
            table1 = connector.FindObject("1", textSearch.Text.Trim());
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
            table2 = connector.LoadData("2");
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
            table2 = connector.FindObject("2", textSearch2.Text.Trim());
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
            table3 = connector.LoadData("3");
            IDstring3 = "";
            foreach (DataRow row in table3.Rows)
            {
                IDstring3 = IDstring3 + row[0].ToString().Trim() + "/";
            }
            table4 = connector.LoadData("4");
            IDstring4 = "";
            foreach (DataRow row in table4.Rows)
            {
                IDstring4 = IDstring4 + row[0].ToString().Trim() + "/";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedItems[0].Index;
                textBookID.Text = table1.Rows[index][0].ToString();
                textTittle.Text = table1.Rows[index][1].ToString();
                textAuthor.Text = table1.Rows[index][2].ToString();
                textGenre.Text = table1.Rows[index][3].ToString();
                textPub.Text = table1.Rows[index][4].ToString();
                textYear.Text = table1.Rows[index][5].ToString();
                textPrice.Text = table1.Rows[index][6].ToString();
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                int index = listView2.SelectedItems[0].Index;
                textBookID2.Text = table2.Rows[index][0].ToString();
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
                    textBookID.ReadOnly = textTittle.ReadOnly = textAuthor.ReadOnly = textGenre.ReadOnly = textPub.ReadOnly = textYear.ReadOnly = textPrice.ReadOnly = true;
                }
                else
                {
                    butFree.Enabled = true;
                    textBookID.ReadOnly = true;
                    textTittle.ReadOnly = textAuthor.ReadOnly = textGenre.ReadOnly = textPub.ReadOnly = textYear.ReadOnly = textPrice.ReadOnly = false;
                    if (rad.Text == "Add")
                    {
                        textBookID.ReadOnly = false;
                        textBookID.Text = textTittle.Text = textAuthor.Text = textGenre.Text = textPub.Text = textYear.Text = textPrice.Text = "";
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
                    textBookID2.ReadOnly = textUnique.ReadOnly = true;
                }
                else
                {
                    butFree2.Enabled = true;
                    textBookID2.ReadOnly = true;
                    textUnique.ReadOnly = false;
                    if (rad.Text == "Add")
                    {
                        textBookID2.ReadOnly = false;
                        textBookID2.Text = textUnique.Text = "";
                    }
                }
            }
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                connector.DeleteObject("1", textBookID.Text.Trim(), "");
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
                connector.DeleteObject("2", textBookID2.Text.Trim(), textUnique.Text.Trim());
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
                if (textBookID.Text.Trim() == "")
                {
                    MessageBox.Show("ID's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBookID.Focus();
                    return false;
                }
                for (int i = 0; i < table1.Rows.Count; i++)
                {
                    if (textBookID.Text.Trim() == table1.Rows[i][0].ToString().Trim())
                    {
                        MessageBox.Show("ID's values has been taken, please input new ID", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        textBookID.Focus();
                        return false;
                    }
                }
            }
            int a;
            if (int.TryParse(textYear.Text, out a) == false)
            {
                MessageBox.Show("This Year is not valid", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textYear.Focus();
                return false;
            }
            if (int.TryParse(textPrice.Text, out a) == false)
            {
                MessageBox.Show("This Price is not valid", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textPrice.Focus();
                return false;
            }
            if (textTittle.Text.Trim() == "")
            {
                MessageBox.Show("Tittle's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textTittle.Focus();
                return false;
            }
            if (textAuthor.Text.Trim() == "")
            {
                MessageBox.Show("Author's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textAuthor.Focus();
                return false;
            }
            if (textGenre.Text.Trim() == "")
            {
                MessageBox.Show("Genre's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textGenre.Focus();
                return false;
            }
            if (textPub.Text.Trim() == "")
            {
                MessageBox.Show("Publisher's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textPub.Focus();
                return false;
            }
            int p = 0;
            for (int i = 0; i < table3.Rows.Count; i++)
            {
                if (textPub.Text.Trim() == table3.Rows[i][0].ToString().Trim())
                {
                    p = 1;
                    break;
                }
            }
            if (p == 0)
            {
                MessageBox.Show("Publisher ID's values must be in {" + IDstring3 + "}", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textPub.Focus();
                return false;
            }
            p = 0;
            for (int i = 0; i < table4.Rows.Count; i++)
            {
                if (textGenre.Text.Trim() == table4.Rows[i][0].ToString().Trim())
                {
                    p = 1;
                    break;
                }
            }
            if (p == 0)
            {
                MessageBox.Show("Genre ID's values must be in {" + IDstring4 + "}", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textGenre.Focus();
                return false;
            }
            return true;
        }
        private bool check2(int k)
        {
            if (k == 1)
            {
                if (textBookID2.Text.Trim() == "")
                {
                    MessageBox.Show("ID's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBookID.Focus();
                    return false;
                }
                for (int i = 0; i < table1.Rows.Count; i++)
                {
                    if (textBookID2.Text.Trim() == table1.Rows[i][0].ToString().Trim())
                    {
                        MessageBox.Show("ID's values has been taken, please input new ID", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        textBookID.Focus();
                        return false;
                    }
                }
            }
            if (textUnique.Text.Trim() == "")
            {
                MessageBox.Show("Unique's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textUnique.Focus();
                return false;
            }
            for (int i = 0; i < table2.Rows.Count; i++)
            {
                if (textUnique.Text.Trim() == table2.Rows[i][1].ToString().Trim())
                {
                    MessageBox.Show("This Unique values has been taken, please input new one", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textUnique.Focus();
                    return false;
                }
            }
            int p = 0;
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                if (textBookID2.Text.Trim() == table1.Rows[i][0].ToString().Trim())
                {
                    p = 1;
                    break;
                }
            }
            if (p == 0)
            {
                MessageBox.Show("Book ID's values must be in {" + IDstring1 + "}", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBookID2.Focus();
                return false;
            }
            return true;
        }

        private void butFree_Click(object sender, EventArgs e)
        {
            if (butFree.Text == "Add")
            {
                if (check1(1) == false) return;
                connector.InsertUpdateObject("AddObject", "1", textBookID.Text, textGenre.Text, textPub.Text, textTittle.Text, textAuthor.Text, "", "1/1/1994","1/1/1994", textYear.Text, textPrice.Text, "");
                MessageBox.Show("Inserting completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (check1(2) == false) return;
                connector.InsertUpdateObject("EditObject", "1", textBookID.Text, textGenre.Text, textPub.Text, textTittle.Text, textAuthor.Text,"", "1/1/1994", "1/1/1994", textYear.Text, textPrice.Text, "");
                MessageBox.Show("Updating completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reset11();
        }

        private void butFree2_Click(object sender, EventArgs e)
        {
            if (butFree2.Text == "Add")
            {
                if (check2(1) == false) return;
                connector.InsertUpdateObject("AddObject", "2", textBookID2.Text, textUnique.Text, "", "", "", "", "1/1/1994", "1/1/1994", "", "", "");
                MessageBox.Show("Inserting completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (check2(2) == false) return;
                connector.InsertUpdateObject("EditObject", "2", textBookID2.Text, textUnique.Text, "", "", "", "", "1/1/1994", "1/1/1994", "", "", "");
                MessageBox.Show("Updating completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reset21();
        }

    }
}
