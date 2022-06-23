using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using WindowsFormsApp1.Classes;
using Microsoft.Win32;

namespace WindowsFormsApp1
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public static string  Fullname, isglobalUserID;

        RegistryKey regkey;
        string password;
        string encryptedpassword;
        string decryptedpassword;
        public static string userid;
        public static string serverpassword;
        public static string servername;
        public static string dbname;
        public static string connsettings;

        public Login()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtuserid.Text.Trim() == "")
            {
                XtraMessageBox.Show("User id is required.");
                return;
            }
            if (txtpassword.Text.Trim() == "")
            {
                XtraMessageBox.Show("Password is required.");
                return;
            }

            get_password();
        }
        private void get_password()
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            SqlCommand com = new SqlCommand("Select Password from Users where UserID = '" + txtuserid.Text + "'", con);
            SqlDataReader reader = com.ExecuteReader();
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        password = reader["Password"].ToString();
                        decrypt_password();
                        return;
                    }
                }
                XtraMessageBox.Show("Invalid User ID.", "IT Core Solutions Inc.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                txtpassword.Focus();
                txtpassword.SelectionStart = 0;
                txtpassword.SelectionLength = txtpassword.Text.Length;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void decrypt_password()
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            SqlCommand com = new SqlCommand("declare @pwd varchar(50) exec master..xp_aes_decrypt '" + password + "','0123456789ABCDEF0123456789ABCDEF',@pwd output select @pwd result", con);
            SqlDataReader reader = com.ExecuteReader();
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        decryptedpassword = reader["result"].ToString();
                        validate_user();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        private void encrypt()
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            SqlCommand com = new SqlCommand("exec master..xp_aes_encrypt '" + txtpassword.Text + "','0123456789ABCDEF0123456789ABCDEF'", con);
            SqlDataReader reader = com.ExecuteReader();
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        encryptedpassword = reader["result"].ToString();
                        validate_user();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                regkey = Registry.CurrentUser.CreateSubKey(@"AAITCRE\ConnSettingsMain");
                if (regkey.GetValue("dbconn") == null)
                {
                    Connection C = new Connection();
                    C.lblservername.Text = "Main Server";
                    C.txtconnsettingsname.Text = @"AAITCRE\ConnSettingsMain";
                    C.ShowDialog();
                    this.Opacity = 0;
                    return;
                }
                else
                {
                    // constr = regkey.GetValue("dbconn").ToString();
                    userid = regkey.GetValue("serverid").ToString();
                    serverpassword = regkey.GetValue("serverpassword").ToString();
                    dbname = regkey.GetValue("dbname").ToString();
                    servername = regkey.GetValue("servername").ToString();
                }
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
        }

        private void validate_user()
        {
            SqlConnection con = Database.getConnection();
            con.Open();
            SqlCommand com = new SqlCommand("Select TOP(1) * from dbo.Users where UserID= '" + txtuserid.Text + "' and Password = '" + password + "'", con);
            //SqlCommand com = new SqlCommand("Select * from UserMenuAccess2 where UserID= '"+txtuserid.Text+"'  ", con);
            SqlDataReader reader = com.ExecuteReader();
            try
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                      
                            Fullname = reader["FullName"].ToString();
                            isglobalUserID = reader["UserID"].ToString();
                            this.Hide();
                            Main m = new Main();
                            m.Show();
                            return;
                    }
                }
                else
                {
                    XtraMessageBox.Show("Invalid User ID or Password given.", "IT Core Solutions Inc.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtpassword.Focus();
                    txtpassword.SelectionStart = 0;
                    txtpassword.SelectionLength = txtpassword.Text.Length;
                    return;
                }
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}