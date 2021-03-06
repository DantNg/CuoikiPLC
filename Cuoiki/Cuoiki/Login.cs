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
        SqlConnection strcon = new SqlConnection(@"Data Source=DESKTOP-5SRCC15\SQLEXPRESS;Initial Catalog=ManagerAccount;Integrated Security=True");

        bool openHMI = false;
        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Truy cập đến sql server
                if (strcon.State == ConnectionState.Closed)
                    strcon.Open();
                SqlCommand cmd = new SqlCommand("select * from ManagerAccount where Username='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "' ", strcon);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    lbSuccessfully.Visible = true;
                    lbWrong.Visible = false;
                    openHMI = true;
                    MainHMI mainHMI = new MainHMI();
                    mainHMI.ShowDialog();
                    
                }
                else
                {
                    lbSuccessfully.Visible = false;
                    lbWrong.Visible = true;
                    openHMI = false;
                }
                reader.Close();
                if (strcon.State == ConnectionState.Open)
                    strcon.Close();
               if( openHMI) this.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error");
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


        private void isShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(isShowPass.Checked )
            {
                if (txtPassword.PasswordChar.ToString() == "●")
                {
                    txtPassword.PasswordChar = '\0';
                }
              
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }
    }
}
