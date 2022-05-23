using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace TaiXiu
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            //Ban dau an tat ca cac label warning
            lbAlrealyExists.Hide();
            lbEnterInfo.Hide();
            lbPassSame.Hide();
        }

        //Watermask of username
        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (tbUsername.Text.Trim() == "")
            {
                tbUsername.Text = "Username";
                tbUsername.ForeColor = Color.Silver;
            }
            if (tbUsername.Text.ToLower().Trim() == "username")
                tbUsername.ForeColor = Color.Silver;
        }

        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text.ToLower().Trim() == "username")
            {
                tbUsername.Text = "";
                tbUsername.ForeColor = Color.Black;
            }
            else
                tbUsername.ForeColor = Color.Black;
        }

        //Watermask of tbPassword
        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text.ToLower().Trim() == "password")
            {
                tbPassword.Text = "";
                tbPassword.UseSystemPasswordChar = true;
                tbPassword.ForeColor = Color.Black;
            }
            else
                tbPassword.ForeColor = Color.Black;
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text.Trim() == "" || tbPassword.Text.ToLower().Trim().Equals("password"))
            {
                tbPassword.Text = "Password";
                tbPassword.UseSystemPasswordChar = false;
                tbPassword.ForeColor = Color.Silver;
            }
        }

        //Watermask tbConfirmPass
        private void tbConfirmPass_Leave(object sender, EventArgs e)
        {
            if (tbConfirmPass.Text.Trim() == "" || tbConfirmPass.Text.ToLower().Trim().Equals("password")
                || tbConfirmPass.Text.ToLower().Trim().Equals("confirm password") || tbConfirmPass.Text.ToLower().Trim().Equals("confirmpassword"))
            {
                tbConfirmPass.Text = "Confirm Password";
                tbConfirmPass.UseSystemPasswordChar = false;
                tbConfirmPass.ForeColor = Color.Silver;
            }
        }

        private void tbConfirmPass_Enter(object sender, EventArgs e)
        {
            if (tbConfirmPass.Text.ToLower().Trim().Equals("confirm password"))
            {
                tbConfirmPass.Text = "";
                tbConfirmPass.UseSystemPasswordChar = true;
                tbConfirmPass.ForeColor = Color.Black;
            }
            else
                tbConfirmPass.ForeColor = Color.Black;
        }


        //BtnExit
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            //Use SQL command
            DataBase dataBase = new DataBase();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `users`( `username`, `password`) VALUES (@usn, @pass)", dataBase.getConnection());
            cmd.Parameters.Add("@usn", MySqlDbType.VarChar).Value = tbUsername.Text;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = tbPassword.Text;

            dataBase.openConnection();

            if (!check_value_textboxs())
            {
                //Check if password equal confirm password
                if (tbPassword.Text.Equals(tbConfirmPass.Text))
                {
                    //Check if account alrealy exists
                    if (check_username())
                        lbAlrealyExists.Show();
                    else
                    {
                        //execute query
                        if (cmd.ExecuteNonQuery() == 1)
                            MessageBox.Show("ACCOUNT CREATED", "THÔNG BÁO");
                        else
                            MessageBox.Show("FAILED CREATION", "THÔNG BÁO");
                    }

                }
                else
                    lbPassSame.Show();
            }
            else
                lbEnterInfo.Show();

            dataBase.closeConnection();
        }

        //Check if account alrealy exists

        public Boolean check_username()
        {
            DataBase dataBase = new DataBase();
            string username = tbUsername.Text;

            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", dataBase.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);

            //Database has had alrealy account, hasn't it?
            if (dataTable.Rows.Count > 0)
                return true;
            else
                return false;
        }

        //Check values of all textbox

        public Boolean check_value_textboxs()
        {
            string pass = tbPassword.Text;
            string user = tbUsername.Text;

            if (pass.Equals("Password") || user.Equals("Username"))
                return true;
            else
                return false;
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            lbEnterInfo.Hide();
            lbAlrealyExists.Hide();
            lbPassSame.Hide();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            lbEnterInfo.Hide();
            lbAlrealyExists.Hide();
            lbPassSame.Hide();
        }

        private void tbConfirmPass_TextChanged(object sender, EventArgs e)
        {
            lbEnterInfo.Hide();
            lbAlrealyExists.Hide();
            lbPassSame.Hide();
        }

        private void lbSignIn_MouseEnter(object sender, EventArgs e)
        {
            lbSignIn.ForeColor = Color.Yellow;
        }

        private void lbSignIn_MouseLeave(object sender, EventArgs e)
        {
            lbSignIn.ForeColor= Color.Red;
        }

        private void lbSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
