using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkApp
{
    public partial class UserControl : Form
    {

        public Logic logic;
        public UserControl(Logic _logic)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();

            logic = _logic;
            UpdateList();

        }
        private void UpdateList()
        {
            usersBox.Items.Clear();

            foreach (var user in logic._context.Logins)
            {
                usersBox.Items.Add(user.Id.ToString()+": "+user.LoginString+" , "+user.Role);
            }
        }
        private void usersBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(unBox.Text!="" && pswdBox.Text != "")
            {
                try
                {
                    logic._context.AddUser(unBox.Text, pswdBox.Text);
                    if (rightsBox.Checked)
                    {
                        logic._context.AddAdminRights(unBox.Text);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Failed");
                }
                

            }
            else
            {
                MessageBox.Show("Incorrect data");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void unBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = (e.KeyValue == (char)Keys.Space);
        }

        private void pswdBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = (e.KeyValue == (char)Keys.Space);
        }
    }
}
