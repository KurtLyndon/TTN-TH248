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
    public partial class frmPhanCong : Form
    {
        public frmPhanCong()
        {
            InitializeComponent();
        }

        private DataTable table;
        private DataTable table1;
        private DataTable table2;
        private string IDstring1;
        private string IDstring2;
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

        private void reset3()
        {
            table1 = new DataTable();
            table1 = connector.LoadData("1");
            IDstring1 = "";
            foreach (DataRow row in table.Rows)
            {
                IDstring1 = IDstring1 + row[0].ToString().Trim() + "/";
            }
            table2 = new DataTable();
            table2 = connector.LoadData("3");
            IDstring2 = "";
            foreach (DataRow row in table.Rows)
            {
                IDstring2 = IDstring2 + row[0].ToString().Trim() + "/";
            }
        }
        
        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            reset();
            reset3();
        }

        private bool check(int k)
        {
            if (k == 1)
            {
                if (textID.Text.Trim() == "")
                {
                    MessageBox.Show("Employee ID's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textID.Focus();
                    return false;
                }
                if (textID2.Text.Trim() == "")
                {
                    MessageBox.Show("Project ID's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textID2.Focus();
                    return false;
                }
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (textID.Text.Trim() == table.Rows[i][0].ToString().Trim()&&textID2.Text.Trim()==table.Rows[i][2].ToString().Trim())
                    {
                        MessageBox.Show("This allocation has already been in the list, please input new pair ID", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        textID.Focus();
                        return false;
                    }
                }
            }
            if (textTime.Text.Trim() == "")
            {
                MessageBox.Show("Name's values must not be null", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textTime.Focus();
                return false;
            }
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                if (textID.Text.Trim() == table1.Rows[i][0].ToString().Trim())
                {
                    MessageBox.Show("Employee ID's values must be in {" + IDstring1 + "}", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textID.Focus();
                    return false;
                }
            }
            for (int i = 0; i < table2.Rows.Count; i++)
            {
                if (textID2.Text.Trim() == table2.Rows[i][0].ToString().Trim())
                {
                    MessageBox.Show("Project ID's values must be in {" + IDstring2 + "}", "O___O", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textID2.Focus();
                    return false;
                }
            }
            return true;
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
                    textID2.ReadOnly = textTime.ReadOnly = true;
                }
                else
                {
                    btnFree.Enabled = true;
                    textID.ReadOnly = false;
                    textID2.ReadOnly = textTime.ReadOnly = false;
                    if (rad.Text == "Add")
                    {
                        textID.ReadOnly = false;
                        textID2.Text = textTime.Text = textID.Text = "";
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedItems[0].Index;
                textID.Text = table.Rows[index][0].ToString();
                textTime.Text = table.Rows[index][1].ToString();
                textID2.Text = table.Rows[index][2].ToString();
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

        private void butDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                connector.DeleteObject("5", textID.Text.Trim(), textID2.Text.Trim());
                if (butSearch.Text.Trim() == "Search Mode")
                {
                    reset2();
                }
                else reset();
                MessageBox.Show("Deleting completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            if (btnFree.Text == "Add")
            {
                if (check(1) == false) return;
                connector.InsertUpdateObject("AddObject", "5", textID.Text, textID2.Text, "", "", "", "1/1/1994", "", "", "", textTime.Text);
                MessageBox.Show("Inserting completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (check(2) == false) return;
                connector.InsertUpdateObject("EditObject", "5", textID.Text, textID2.Text, "", "", "", "1/1/1994", "", "", "", textTime.Text);
                MessageBox.Show("Updating completed", "^...^", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            reset();
        }

    }
}
