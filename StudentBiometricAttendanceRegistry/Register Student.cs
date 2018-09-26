using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecuGen.SecuBSPPro.Windows;
using MySql.Data.MySqlClient;
using System.IO;


namespace StudentBiometricAttendanceRegistry
{
    public partial class Register_Student : Form
    {
        // calling secuGen Class constructor

        //private fixed int values[10];
        string imgLoc = " ";
        private SecuBSPMx m_SecuBSP;
        private bool m_DeviceOpened;

        private string m_EnrollFIRText;
        

        public Register_Student()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addLec_btn_Click(object sender, EventArgs e)
        {

        }

        private void OpenDeviceBtn_Click(object sender, EventArgs e)
        {
            BSPError err;

            if (m_DeviceOpened)
            {
                m_SecuBSP.CloseDevice();
                m_DeviceOpened = false;
            }

            // Get Selected device by User
            string selected_device = DeviceIDCombo.Text;
            selected_device = selected_device.Substring(0, 6);
            Int16 device_id = Convert.ToInt16(selected_device.Substring(0, 6), 16);

            m_SecuBSP.DeviceID = device_id;

            err = m_SecuBSP.OpenDevice();
            DisplaySecuBSPErrMsg("OpenDevice", err);
            if (err != BSPError.ERROR_NONE)
                return;

            m_DeviceOpened = true;
        }

   
 
        private void enumerate_btn_Click(object sender, EventArgs e)
        {
            BSPError err;
            DeviceIDCombo.Items.Clear();

            DeviceIDCombo.Items.Add("0x00ff (Auto Detect)");
            err = m_SecuBSP.EnumerateDevice();
            if (err == BSPError.ERROR_NONE)
            {
                for (int i = 0; i < m_SecuBSP.DeviceNum; i++)
                {
                    Int16 device_id = m_SecuBSP.GetDeviceID(i);

                    string device_id_info;
                    device_id_info = "0x" + MakeHexaDecimal(device_id, 4) + "  ("
                       + m_SecuBSP.GetDeviceName(device_id) + ","
                       + m_SecuBSP.GetDeviceInstanceNum(device_id) + ")";

                    DeviceIDCombo.Items.Add(device_id_info);

                }
            }
            DisplaySecuBSPErrMsg("EnumerateDevice", err);
        }
        //----------------------------------------------------
        private void DisplaySecuBSPErrMsg(string funcName, BSPError errNum)
        {
            if (errNum == 0)
                StatusBar.Text = funcName + "()" + " :Success";
            else
                StatusBar.Text = funcName + "()" + " :Error occurred. Err# = " + Convert.ToString(errNum);
        }

        //----------------------------------------------------
        string MakeHexaDecimal(Int32 numbers, Int32 digit)
        {
            string dest_str = "0000000000000000"; // digit can not exceed 16

            string str = Convert.ToString(numbers, 16);
            Int32 len = str.Length;

            if (len > digit)
                dest_str = "";
            else
                dest_str = dest_str.Substring(0, digit - len) + str;

            return dest_str;
        }

        private void Register_Student_Load(object sender, EventArgs e)
        {
            DeviceIDCombo.Items.Add("0x00FF (Auto Detect)");
            m_DeviceOpened = false;

            m_SecuBSP = new SecuBSPMx();

            m_EnrollFIRText = "";
          

            enumerate_btn_Click(sender, e);
        }

        private void registerStudent_btn_Click(object sender, EventArgs e)
        {
            
            try
            {
                // post browsed image to database
                string sql = string.Empty;
                string con = string.Empty;
                byte[] imageData = null;
                FileStream mfilestream = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader bireader = new BinaryReader(mfilestream);
                imageData = bireader.ReadBytes((int)mfilestream.Length);
                bireader.Close();
                mfilestream.Close();

                // check connection and connect to the database
                //String con = string.Empty;
                con = "Server=127.0.0.1; port=3306; Uid=root; Database=Studentdb; Password=";
                //string sql = string.Empty;
                sql = @"INSERT  INTO student_details (RegistrationNumber, First_Name,Last_Name,student_passport, Student_Fingerprint, phone_Number, email_Address, course, Year)VALUES (@RegistrationNumber,@FirstName,@LastName, @StudentPassport,@StudentFingerprint, @PhoneNumber, @Email, @Course,@Year)";
                using (MySqlConnection sqlcon = new MySqlConnection(con))
                {
                    sqlcon.Open();
                    using (MySqlCommand com = new MySqlCommand(sql, sqlcon))
                    {
                        if (regNo_txt.Text != "" || fname_txt.Text != "" || lname_txt.Text != "" || labelFingerprint.Text != "" || phoneNo_txt.Text != "" || email_txt.Text != "" || selectCourse_cmx.Text != "" || year_txt.Text != "") 
                        {
                            ////get values from users
                            com.Parameters.AddWithValue("@RegistrationNumber", regNo_txt.Text);
                            com.Parameters.AddWithValue("@FirstName", fname_txt.Text);
                            com.Parameters.AddWithValue("@LastName", lname_txt.Text);
                            com.Parameters.AddWithValue("@StudentFingerprint", labelFingerprint.Text);
                            com.Parameters.AddWithValue("@StudentPassport", imageData); // in place of image
                            com.Parameters.AddWithValue("@PhoneNumber", phoneNo_txt.Text);
                            com.Parameters.AddWithValue("@Email", email_txt.Text);
                            com.Parameters.AddWithValue("@Course", selectCourse_cmx.Text);
                            com.Parameters.AddWithValue("@Year", year_cbx.Text);

                            MySqlConnection sqlcon2 = new MySqlConnection(con);
                            sqlcon2.Open();
                            string Select;
                            Select = "SELECT * FROM student_details WHERE RegistrationNumber='" + regNo_txt.Text + "'";
                            using (MySqlCommand cm = new MySqlCommand(Select, sqlcon2))
                            {
                                using (MySqlDataReader auth = cm.ExecuteReader())
                                {
                                    if (auth.HasRows)
                                    {
                                        MessageBox.Show("Your details already exists in our database,Thank you");
                                        sqlcon.Close();
                                    }
                                    else
                                    {
                                      
                                        
                                            com.ExecuteNonQuery();
                                        sqlcon2.Close();
                                    }
                                }

                            }
                                //if successful
                                MessageBox.Show("Processing Complete.....");

                        }
                        else
                        {
                            MessageBox.Show("other fields apart from image and course must be filled");
                        }
                    }
                }
                //clear text boxes
                regNo_txt.Text = " ";
                fname_txt.Text = " ";
                lname_txt.Text = " ";
                labelFingerprint.Text = " ";
                phoneNo_txt.Text = " ";
                email_txt.Text = " ";
                selectCourse_cmx .Text = " ";
                year_txt.Text = " ";
                             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem Adding to database" + ex);
            }
        }
private void captureFingerprint_btn_Click(object sender, EventArgs e)
        {
            BSPError err;
            err = m_SecuBSP.Enroll(regNo_txt.Text);

            if (err == BSPError.ERROR_NONE)
            {
                m_EnrollFIRText = m_SecuBSP.FIRTextData;
                labelFingerprint.Text = m_EnrollFIRText;
            }

            DisplaySecuBSPErrMsg("Enroll", err);
        }

        private void addCourse_btn_Click(object sender, EventArgs e)
        {
           // call method to display form adding course
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
         
        }

        private void browseimage_btn_Click(object sender, EventArgs e)
        {

            try
            {
                // Browse for student image
                OpenFileDialog browseImage = new OpenFileDialog();
                browseImage.Filter = "JPG Files (*.jpg) | *.jpg |GIF Files (*.gif) | *.gif|ALL Files (*.*)|*.*";
                browseImage.Title = "Browse image";
                if (browseImage.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = browseImage.FileName.ToString();
                    passportPicBox.ImageLocation = imgLoc;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectCourse_cmx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeviceIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StatusBar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home_frm log = new Home_frm();
            log.Show();
            this.Hide();
        }
    }

}
    

