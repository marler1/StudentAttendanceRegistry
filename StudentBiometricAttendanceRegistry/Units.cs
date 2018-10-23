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
    public partial class unitName_cb : Form
    {
        public unitName_cb()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void addUnit_btn_Click(object sender, EventArgs e)
        {
            try
            {

                // check connection and connect to the database
                String con = string.Empty;
                con = "Server=127.0.0.1; SslMode=none;port=3306; Uid=root; Database=Studentdb; Password=";
                string sql = string.Empty;
                sql = @"INSERT  INTO units (unit_Code,unit_Name,Lecturer,Course,Year)VALUES (@UnitCode,@UnitName,@Lecturer,@Course,@Year)";
                using (MySqlConnection sqlcon = new MySqlConnection(con))
                {
                    sqlcon.Open();
                    using (MySqlCommand com = new MySqlCommand(sql, sqlcon))
                    {
                        if (unitCode_cb.Text != "" || unitName_txt.Text != "" || lecturer_txt.Text != "" || course_cb.Text != "" || year_cb.Text != "")
                        {
                            //get values from users
                            com.Parameters.AddWithValue("@UnitCode", unitCode_cb.Text);
                            com.Parameters.AddWithValue("@UnitName", unitName_txt.Text);
                            com.Parameters.AddWithValue("@Lecturer", lecturer_txt.Text);
                            com.Parameters.AddWithValue("@Course", course_cb.Text);
                            com.Parameters.AddWithValue("@Year", year_cb.Text);
                           
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
                unitCode_cb.Text = " ";
                unitName_txt.Text = " ";
                lecturer_txt.Text = " ";
                course_cb.Text = " ";
                year_cb.Text = " ";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem Adding to database" + ex);
            }
        }

        private void adminLogout_btn_Click(object sender, EventArgs e)
        {
            Home_frm log = new Home_frm();
            log.Show();
            this.Hide();
        }

        private void unitName_cb_Load(object sender, EventArgs e)
        {

        }
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
