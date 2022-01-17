using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet19_managerProduct
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (userName.Text == "" || userPassword.Text == "")
            {
                MessageBox.Show(" Please Entrer votre nom et votre mot de pass ");

            }
            else
            {

                DBConnect dbconnect = new DBConnect();
                bool v;
                v = dbconnect.Auth(userName.Text, userPassword.Text);

                if (v)
                {
                    MessageBox.Show(" Successfully logged in !!!");

                    product product = new product();
                    this.Hide();
                    product.Show();

                }
                else
                {
                    MessageBox.Show(" Vérifier votre nom user ou mot de passe!!! ");
                }



            }
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void userPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
