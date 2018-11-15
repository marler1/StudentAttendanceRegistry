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
using System.Text.RegularExpressions;

namespace StudentBiometricAttendanceRegistry

{
    public partial class Add_Lecturer : Form
    {


        public Add_Lecturer()
        {
            InitializeComponent();

        }

        private void submitLecDetails_btb_Click(object sender, EventArgs e)
        {
            if (lecFname_txt.Text == "")
            {
                MessageBox.Show("Please fill in the first name!!");
            }
            else if (lecLname_txt.Text == "")
            {
                MessageBox.Show("Please fill in the last name!!");
            }
            else if (lecTel_txt.Text == "")
            {
                MessageBox.Show("Please fill in the Phone Number!!");
            }
            else if (lecEmail_txt.Text == "")
            {
                MessageBox.Show("Please fill in the Email!!");
            }
            else if (lecUsername_txt.Text == "")
            {
                MessageBox.Show("Please fill in the Username!!");
            }
            else if (lecPassword_txt.Text == "")
            {
                MessageBox.Show("Please fill in the Password!!");
            }
            else
            {
                try
                {
                    DateTime dnm = new System.DateTime();
                    string dei = dnm.Day.ToString();

                    // check connection and connect to the database
                    String con = string.Empty;
                    con = "Server=127.0.0.1; SslMode=none; port=3306; Uid=root; Database=Studentdb; Password=";
                    string sql = string.Empty;
                    sql = @"INSERT  INTO login (fName,lName,telephone,email,username,password, role)VALUES (@FirstName,@LastName,@Telephone,@Email,@Username,@Password,1)";
                    using (MySqlConnection sqlcon = new MySqlConnection(con))
                    {
                        sqlcon.Open();
                        using (MySqlCommand com = new MySqlCommand(sql, sqlcon))
                        {

                            //get values from users
                            com.Parameters.AddWithValue("@FirstName", lecFname_txt.Text);
                            com.Parameters.AddWithValue("@LastName", lecLname_txt.Text);
                            com.Parameters.AddWithValue("@Telephone", lecTel_txt.Text);
                            com.Parameters.AddWithValue("@Email", lecEmail_txt.Text);
                            com.Parameters.AddWithValue("@Username", lecUsername_txt.Text);
                            com.Parameters.AddWithValue("@Password", lecPassword_txt.Text);
                            com.ExecuteNonQuery();

                            MessageBox.Show("Details submitted successfully");


                        }
                    }
                    // empty text fields
                    lecFname_txt.Text = " ";
                    lecLname_txt.Text = " ";
                    lecTel_txt.Text = " ";
                    lecEmail_txt.Text = " ";
                    lecUsername_txt.Text = " ";
                    lecPassword_txt.Text = " ";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem Adding to database" + ex);
                }

            }
        }

        private void addLec_btn_Click(object sender, EventArgs e)
        {
            Add_Lecturer addlec = new Add_Lecturer();
            addlec.Show();
            this.Show();
        }

        private void regStudent_btn_Click(object sender, EventArgs e)
        {
            Register_Student reg = new Register_Student();
            reg.Show();
            this.Hide();
        }

        private void adminLogout_btn_Click(object sender, EventArgs e)
        {
            Home_frm log = new Home_frm();
            log.Show();
            this.Hide();
        }

        private void Add_Lecturer_Load(object sender, EventArgs e)
        {
        
        }
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void lecEmail_txt_TextChanged(object sender, EventArgs e)
        {

            string pattern = "^([a-zA-Z0-9]+)@([a-zA-Z0-9]+).([a-zA-Z]{2,5})$";
            if (Regex.IsMatch(lecEmail_txt.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.lecEmail_txt, "Please provide a valid email address");
            }
        }
        // try the KeyPress textbox code here

        private void lecTel_txt_TextChanged(object sender, EventArgs e)
        {
            /*Regex pattern = new Regex(@"\+[0-9]{3}\s+[0-9]{3}\s+[0-9]{5}\s+[0-9]{3}");
            if (pattern.IsMatch(lecTel_txt.Text))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Invalid phone number");
            }*/
        }
        private void addUnit_btn_Click(object sender, EventArgs e)
        {
            unitName_cb addUnit = new unitName_cb();
            addUnit.Show();
            this.Hide();
        }

        private void btnSMS_Click(object sender, EventArgs e)
        {

            frm_message mess = new frm_message();
            mess.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Admin_Portal ap = new Admin_Portal();
            ap.Show();
            this.Hide();
        }
    }
}
