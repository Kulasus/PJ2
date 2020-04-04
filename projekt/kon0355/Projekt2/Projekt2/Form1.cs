using System;
using System.Windows.Forms;

namespace Projekt2
{
    public partial class Form1 : Form
    {
        private UserCollection userCollection = new UserCollection();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_create.Enabled = false;
            btn_edit.Enabled = false;
            btn_delete.Enabled = false;
            btn_find.Enabled = false;
            btn_save.Enabled = false;
            btn_load.Enabled = false;
            radioButton_isActive_null.Checked = true;
            RefreshData();
        }
        private void btn_Create_Click(object sender, EventArgs e)
        {
            int? scoreTmp = Decimal.ToInt32(numericUpDown_score.Value);
            bool? isActiveTmp = null;
            if (radioButton_isActive_true.Checked)
            {
                isActiveTmp = true;
            }
            else if (radioButton_isActive_false.Checked)
            {
                isActiveTmp = false;
            }
            if(!userCollection.Add(new User(textBox_username.Text, scoreTmp, isActiveTmp)))
            {
                MessageBox.Show("User " +textBox_username.Text+ " already exist!");
            }
            RefreshData();
        }
        private void textBox_username_changed(object sender, EventArgs e)
        {
            bool condition = textBox_username.TextLength > 0 && textBox_username.TextLength <= 30;
            btn_create.Enabled = condition;
            btn_delete.Enabled = condition;
            btn_edit.Enabled = condition;
            if (textBox_username.TextLength == 31)
            {
                MessageBox.Show("Username too long. Maximum of 30 characters is allowed.");
            }
        }
        private void RefreshData()
        {
            textBox_data.Text = "";
            foreach(User u in userCollection)
            {
                textBox_data.Text += CreateLine(u);
                textBox_data.Text += Environment.NewLine;
            }
        }
        private string CreateLine(User u)
        {
            string line = u.Username;
            string scoreTmp = u.Score == null ? "null" : u.Score.ToString();
            string isActiveTmp = u.IsActive == null ? "null" : u.IsActive.ToString();
            while(line.Length < 30)
            {
                line += " ";
            }
            line += "   Score: " + scoreTmp + "   Active: " + isActiveTmp;
            return line;
        }
        private void bts_sortAsc_Click(object sender, EventArgs e)
        {
            userCollection.SortByUsernameAsc();
            RefreshData();
        }
        private void btn_sortDesc_Click(object sender, EventArgs e)
        {
            userCollection.SortByUsernameDesc();
            RefreshData();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!XmlWriter.SaveToXML(textBox_filename.Text, userCollection)){
                MessageBox.Show("Invalid filename. Didn't you forget .xml at the end?");
            }
            else
            {
                MessageBox.Show("Saved succesfully to: " + textBox_filename.Text);
            }
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            if(!XmlLoader.LoadFromXml(textBox_path.Text, userCollection))
            {
                MessageBox.Show("File on path doesn't exist! Was the path correct? Didn't you forget .xml at the end?");
            }
            else
            {
                MessageBox.Show("Loaded succesfully from: " + textBox_path.Text);
                RefreshData();
            }
        }
        private void textBox_filename_TextChanged(object sender, EventArgs e)
        {
            btn_save.Enabled = textBox_filename.TextLength > 0;
        }
        private void textBox_path_TextChanged(object sender, EventArgs e)
        {
            btn_load.Enabled = textBox_path.TextLength > 0;
        }
        private void textBox_find_TextChanged(object sender, EventArgs e)
        {
            btn_find.Enabled = textBox_find.TextLength > 0;
        }
        private void btn_find_Click(object sender, EventArgs e)
        {
            User u = userCollection.Get(textBox_find.Text);
            if(u == null)
            {
                MessageBox.Show("User doesn't exist.");
            }
            else
            {
                textBox_username.Text = u.Username;
                numericUpDown_score.Value = !u.Score.HasValue ? 0 : u.Score.Value;
                radioButton_isActive_null.Checked = true;
                if (u.IsActive == true)
                {
                    radioButton_isActive_true.Checked = true;
                }
                else if (u.IsActive == false)
                {
                    radioButton_isActive_false.Checked = true;
                }
            }
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            User u = userCollection.Get(textBox_username.Text);
            if(u == null)
            {
                MessageBox.Show("User doesn't exist.");
            }
            else
            {
                u.Score = Decimal.ToInt32(numericUpDown_score.Value);
                u.IsActive = null;
                if (radioButton_isActive_true.Checked)
                {
                    u.IsActive = true;
                }
                else if (radioButton_isActive_false.Checked)
                {
                    u.IsActive = false;
                }
            }
            RefreshData();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!userCollection.Remove(textBox_username.Text))
            {
                MessageBox.Show("User doesn't exist.");
            }
            else
            {
                MessageBox.Show("User deleted succesfully.");
                RefreshData();
            }
        }
    }
}
