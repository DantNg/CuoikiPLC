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
    public partial class SignUp : Form
    {
        SqlConnection strcon = new SqlConnection(@"Data Source=DESKTOP-5SRCC15\SQLEXPRESS;Initial Catalog=ManagerAccount;Integrated Security=True");
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void bt_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text == txtConfirm.Text)
            {
                //Truy cập vào sql
                try
                {
                    if (strcon.State == ConnectionState.Closed)
                        strcon.Open();
                    SqlCommand cmd = new SqlCommand("select * from ManagerAccount where Username='" + txtUsername.Text + "'", strcon);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        lbSuccessfully.Visible = false;
                        lbExsist.Visible = true;
                        lbWrong.Visible = false;
                    }
                    else
                    {
                        reader.Close();
                        SqlCommand insert = new SqlCommand("insert into ManagerAccount values(@Username,@Password)", strcon);
                        insert.Parameters.AddWithValue("@Username", txtUsername.Text);
                        insert.Parameters.AddWithValue("@Password", txtPassword.Text);
                        insert.ExecuteNonQuery();
                        lbSuccessfully.Visible = true;
                        lbWrong.Visible = false;
                        lbExsist.Visible = false;
                    }
                    if (strcon.State == ConnectionState.Open)
                        strcon.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message, "Error");
                }
            }
            else
            {
                lbSuccessfully.Visible = false;
                lbExsist.Visible = false;
                lbWrong.Visible = true;
            }
        }
    }
}
