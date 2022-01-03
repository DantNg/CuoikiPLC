using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cuoiki
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection strcon = new SqlConnection(@"Data Source=LAPTOP-9FMJD3FN\SQLEXPRESS;Initial Catalog=ManagerAccount;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #region
        private void gradient1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBack_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbAccountLoginIn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (strcon.State == ConnectionState.Closed)
                    strcon.Open();
                SqlCommand cmd = new SqlCommand("select * from ManagerAccount where Username='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "' ", strcon);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    lbSuccessfully.Visible = true;
                    lbWrong.Visible = false;
                    MainHMI mainHMI = new MainHMI();
                    mainHMI.ShowDialog();
                }
                else
                {
                    lbSuccessfully.Visible = false;
                    lbWrong.Visible = true;
                }
                reader.Close();
                if (strcon.State == ConnectionState.Open)
                    strcon.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error");
            }
        }

        private void lbIntro_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar.ToString()== "●")
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }

        private void btForget_Click(object sender, EventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
