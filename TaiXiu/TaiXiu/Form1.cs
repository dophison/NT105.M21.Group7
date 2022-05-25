using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ShowUserInf_Click(object sender, EventArgs e)
        {
            UserInformation userInformation = new UserInformation();
            userInformation.Show();
        }
    }
}
