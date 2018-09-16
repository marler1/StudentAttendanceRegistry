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
    public partial class Add_Lecturer : Form
    {
        public Add_Lecturer()
        {
            InitializeComponent();
        }

        private void submitLecDetails_btb_Click(object sender, EventArgs e)
        {
            try
            {

                // check connection and connect to the database
                String con = string.Empty;
                con = "Server=127.0.0.1; port=3306; Uid=root; Database=Studentdb; Password=";
                string sql = string.Empty;
                sql = @"INSERT  INTO lecturer (lecturer_fName, lecturer_lName,telephone,email,username,password)VALUES (@FirstName,@LastName,@Telephone,@Email,@Username,@Password)";
                using (MySqlConnection sqlcon = new MySqlConnection(con))
                {
                    sqlcon.Open();
                    using (MySqlCommand com = new MySqlCommand(sql, sqlcon))
                    {
                        if (lecFname_txt.Text != "" || lecLname_txt.Text != "" || lecTel_txt.Text != "" || lecEmail_txt.Text != "" || lecUsername_txt.Text != "" || lecPassword_txt.Text != "")
                        {
                            //get values from users
                            com.Parameters.AddWithValue("@FirstName", lecFname_txt.Text);
                            com.Parameters.AddWithValue("@LastName", lecLname_txt.Text);
                            com.Parameters.AddWithValue("@Telephone", lecTel_txt.Text);
                            com.Parameters.AddWithValue("@Email", lecEmail_txt.Text);
                            com.Parameters.AddWithValue("@Username", lecUsername_txt.Text);
                            com.Parameters.AddWithValue("@Password", lecPassword_txt.Text);
                            com.ExecuteNonQuery();

                            //if successful
                            MessageBox.Show("Processing Complete.....");
                                                                         
                        }
                        else
                        {
                            MessageBox.Show("All fields are required to be filled");
                        }
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
            catch(Exception ex)
            {
                MessageBox.Show("Problem Adding to database"+ex);
            }
         
        }

        private void addLec_btn_Click(object sender, EventArgs e)
        {

        }

        private void regStudent_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
