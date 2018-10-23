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

namespace StudentBiometricAttendanceRegistry
{
    public partial class Home_frm : Form
    {
        public Home_frm()
        {
            InitializeComponent();
        }

        private void Home_frm_Load(object sender, EventArgs e)
        {
            DateTime tm = DateTime.Now;

            label5.Text = tm.ToString("yyyy-MM-dd");
        }

        private void AdminLog_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // check connection to the database
                // initialize connection to an empty string
                String con = string.Empty;
                con = "Server=127.0.0.1; SslMode=none;port=3306; Uid=root; Database=Studentdb; Password=";
                string sql = string.Empty;
                sql = @"SELECT login.username, login.password, login.role FROM login WHERE username='" + username_txtbox.Text + "' and password='" + password_txtbox.Text + "'";
                using (MySqlConnection sqlcon = new MySqlConnection(con))
                {
                    sqlcon.Open();
                    string[] Item = new string[1];
                    using (MySqlCommand com = new MySqlCommand(sql, sqlcon))
                    {
                        using (MySqlDataReader auth = com.ExecuteReader())
                        {
                           // if (username_txtbox.Text != "")
                                if (auth.HasRows)
                                {
                                auth.Read();
                                        if (auth["role"].ToString() ==  "0")
                                        {
                                             Admin_Portal mm = new Admin_Portal();
                                             mm.Show();
                                            this.Hide();
                                        }

                                        else if (auth["role"].ToString() == "1")

                                        {
                                            Lecturer_Portal lecportal = new Lecturer_Portal();
                                            lecportal.Show();
                                            this.Hide();
                                        }                                 
                                    
                                        
                                }
                                else
                                {
                                    MessageBox.Show("username or password is incorect. Please Try Again!!" +
                                        "");
                                    username_txtbox.Text = "";
                                    password_txtbox.Text = "";
                                }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error()" + ex);

            }

        }

       /* private void lecLogin_btn_Click(object sender, EventArgs e)
        {
            String con = string.Empty;
            con = "Server=127.0.0.1; port=3306; Uid=root; Database=Studentdb; Password=";
            string sql = string.Empty;
            sql = @"SELECT * FROM lecturer WHERE username='" + username_txtbox.Text + "' and Password='" + password_txtbox.Text + "'";
            using (MySqlConnection sqlcon = new MySqlConnection(con))
            {
                sqlcon.Open();
                string[] Item = new string[1];
                using (MySqlCommand com = new MySqlCommand(sql, sqlcon))
                {
                    using (MySqlDataReader auth = com.ExecuteReader())
                    {
                        if (username_txtbox.Text != "")
                            if (auth.HasRows)
                            {
                                Lecturer_Portal lecportal = new Lecturer_Portal();
                                lecportal.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("username or password is incorrect! please Try Again!!");
                                username_txtbox.Text = "";
                                password_txtbox.Text = "";
                            }
                    }
                }
            }

        }*/

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
