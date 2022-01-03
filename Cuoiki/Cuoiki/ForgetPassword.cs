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
    public partial class ForgetPassword : Form
    {
        SqlConnection strcon = new SqlConnection(@"Data Source=DESKTOP-5SRCC15\SQLEXPRESS;Initial Catalog=ManagerAccount;Integrated Security=True");
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void bt_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirm.Text)
            {
                try
                {
                    if (strcon.State == ConnectionState.Closed)
                        strcon.Open();
                    SqlCommand cmd = new SqlCommand("select * from ManagerAccount where Username='" + txtUsername.Text + "' and Password='"+txtLastPassword.Text+"'", strcon);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        reader.Close();
                        SqlCommand update = new SqlCommand("update ManagerAccount set Password='" + txtPassword.Text + "' where Username='" + txtUsername.Text + "'", strcon);
                        update.ExecuteReader();
                        lbSuccessfully.Visible = true;
                        lbWrong.Visible = false;
                        lbExsist.Visible = false;
                    }
                    else
                    {
                        lbSuccessfully.Visible = false;
                        lbExsist.Visible = true;
                        lbWrong.Visible = false;
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
