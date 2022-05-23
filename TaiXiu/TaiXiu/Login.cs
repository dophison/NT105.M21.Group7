using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//References to SQL connector v4.8 MySql.Data.dll
using MySql.Data.MySqlClient;


//vao localhost/phpmyadmin tao ra database

namespace TaiXiu
{
    public partial class Login : Form
    {
       
        public Login()
        {

            InitializeComponent();
            lbInvalidUser.Hide();
        }
//tbUsername
        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if(tbUsername.Text == "")
            {
                tbUsername.Text = "Username";
                tbUsername.ForeColor = Color.Silver;
            }
            if (tbUsername.Text == "Username")
                tbUsername.ForeColor = Color.Silver;
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Username")
            {
                tbUsername.Text = "";
                tbUsername.ForeColor = Color.Black;
            }
            else
                tbUsername.ForeColor = Color.Black;
        }

//tbPassword
        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.Black;
            }
            else
                tbPassword.ForeColor = Color.Black;
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if(tbPassword.Text == "")
            {
                tbPassword.Text = "Password";
                tbPassword.ForeColor = Color.Silver;
            }
            if(tbPassword.Text == "Password")
                tbPassword.ForeColor= Color.Silver;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Black;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn and `password` = @pass", dataBase.getConnection());
            command.Parameters.Add("@usn",MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass",MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            //Database had account, didn't it?
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Sign in completed", "Thông báo");
                this.Hide();
                PlayGame playGame = new PlayGame();
                playGame.Show();
            }
            else
                lbInvalidUser.Show();

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            lbInvalidUser.Hide();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            lbInvalidUser.Hide();
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void lbSignUp_MouseEnter(object sender, EventArgs e)
        {
            lbSignUp.ForeColor = Color.Yellow;
        }

        private void lbSignUp_MouseLeave(object sender, EventArgs e)
        {
            lbSignUp.ForeColor = Color.Red;
        }
    }
}
