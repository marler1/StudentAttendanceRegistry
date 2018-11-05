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
using SecuGen.SecuBSPPro.Windows;
using System.IO;



namespace StudentBiometricAttendanceRegistry
{


    public partial class Lecturer_Portal : Form

    {
        private SecuBSPMx m_SecuBSP;
        private bool m_DeviceOpened;
        private string m_EnrollFIRText;
        string con = "Server=127.0.0.1;SslMode=none; port=3306; Uid=root; Database=Studentdb; Password=";

        private string m_CaptureFIRText;

        public Lecturer_Portal()
        {
            InitializeComponent();
        }

        private void Lecturer_Portal_Load(object sender, EventArgs e)
        {
            DeviceIDCombo.Items.Add("0x00FF (Auto Detect)");
            m_DeviceOpened = false;

            m_SecuBSP = new SecuBSPMx();

            m_EnrollFIRText = "";

            m_CaptureFIRText = "";
            enumerate_btn_Click(sender, e);
            panelcapture.Visible = false;
            course_cb.Text = "";
            unitAtt_cb.Text = "";
            year_cb.Text = "";
            groupBox3.Visible = false;
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
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void markAttendance_btn_Click(object sender, EventArgs e)
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
            groupBox3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BSPError err;

            m_SecuBSP.CaptureWindowOption.WindowStyle = (int)WindowStyle.INVISIBLE;

            m_SecuBSP.CaptureWindowOption.ShowFPImage = true;

            m_SecuBSP.CaptureWindowOption.FingerWindow = (IntPtr)captureFingerprint.Handle;

            err = m_SecuBSP.Capture(FIRPurpose.VERIFY);
            if (err == BSPError.ERROR_NONE)
            {
                m_CaptureFIRText = m_SecuBSP.FIRTextData;
                string con = String.Empty;
                con = "Server=127.0.0.1; SslMode=none; port=3306; Uid=root; Database=Studentdb; Password=";
                string sql = string.Empty;
                sql = @"SELECT * FROM student_details WHERE course='" + course_cb.Text + "' and Year='" + year_cb.Text + "'";
                using (MySqlConnection sqlcon = new MySqlConnection(con))
                {
                    sqlcon.Open();
                    string regNo;
                    using (MySqlCommand com = new MySqlCommand(sql, sqlcon))
                    {
                        using (MySqlDataReader auth = com.ExecuteReader())
                        {
                            if (course_cb.Text != "")
                                if (auth.HasRows)
                                {
                                    while (auth.Read())
                                    {
                                        m_EnrollFIRText = auth["Student_Fingerprint"].ToString();

                                        

                                        err = m_SecuBSP.VerifyMatch(m_CaptureFIRText, m_EnrollFIRText);
                                        

                                        if (err == BSPError.ERROR_NONE)
                                        {
                                            if (m_SecuBSP.IsMatched)
                                            {
                                                StatusBar.Text = "Matched";
                                                regNo = auth["RegistrationNumber"].ToString();
                                             
                                                
                                                addAttendance(unitAtt_cb.Text, course_cb.Text, regNo);
                                            }

                                            else
                                                StatusBar.Text = "Not Matched";


                                        }
                                        else
                                            DisplaySecuBSPErrMsg("VerifyMatch", err);

                                    }
                                }
                        }
                    }

                    DisplaySecuBSPErrMsg("Capture", err);

                }

            }
        }

        private void lecLogout_btn_Click(object sender, EventArgs e)
        {
            Home_frm log = new Home_frm();
            log.Show();
            this.Hide();
        }
        private void addAttendance(string unit, string course, string reg) {

            //fingers used caleb right thumb
            //evans right index
            // kerema left thumb
            DateTime dtm = DateTime.Now;
            string dayt = dtm.ToString("yyyy-MM-dd");
            //string readDay;

            string select = @"SELECT * FROM attendance WHERE  unit='" + unit + "' and RegistrationNumber = '" + reg+"'";
            using (MySqlConnection sqlcon = new MySqlConnection(con))
            {
                sqlcon.Open();
                string[] Item = new string[1];
                using (MySqlCommand com = new MySqlCommand(select, sqlcon))
                {
                    using (MySqlDataReader auth = com.ExecuteReader())
                    {
                        if (auth.HasRows)
                        {
                            while (auth.Read()) {
                                string attend = auth["counter"].ToString();
                                string tday = auth["date"].ToString();
                                if (tday == dayt)
                                {
                                    MessageBox.Show("Sorry you have already taken attendance for today. Thank you");
                                }
                                else {
                                    int atted = int.Parse(attend) + 1;
                                    string quer = "UPDATE attendance SET COUNT ='" + atted + "' WHERE RegistrationNumber '" + reg;
                                }
                            }

                           
                        }
                        else {
                            string sql = "INSERT INTO attendance(date,unit,RegistrationNumber,course,counter)VALUES(@date,@unit,@reg,@course,@counter)";
                            using (MySqlConnection cn = new MySqlConnection(con))
                            {
                                cn.Open();
                                string updateAtt = "1";
                                using (MySqlCommand cm = new MySqlCommand(sql, cn))
                                {
                                    cm.Parameters.AddWithValue("@date", dayt);
                                    cm.Parameters.AddWithValue("@unit", unit);
                                    cm.Parameters.AddWithValue("@reg", reg);
                                    cm.Parameters.AddWithValue("@course", course);
                                    cm.Parameters.AddWithValue("@counter", updateAtt);
                                    

                                    cm.ExecuteNonQuery();
                                    loadList();
                                }
                            }
                        }
                          

                                    }
                                }
                    }
                }
            
            
        
      
        private void loadList() {
            try
            {
                DateTime tm = DateTime.Now;
                string tday = tm.ToString("yyyy-MM-dd");
                string sql23 = "SELECT date, unit, RegistrationNumber, course, counter FROM attendance";
                string conn = "Server=127.0.0.1; SslMode=none; port=3306; Uid=root; Database=Studentdb; Password=";


                using (MySqlConnection sqlcon3 = new MySqlConnection(conn))
                {
                    MySqlDataAdapter adapt = new MySqlDataAdapter(sql23, sqlcon3);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlcon3.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        
            
           
        }

        private void btnStartclass_Click(object sender, EventArgs e)
        {
            if (course_cb.Text == "" || unitAtt_cb.Text == "" || year_cb.Text == "")
            {
                 MessageBox.Show("Please Select all fields!!");
            }
            else {
               panelcapture.Visible = true;
                loadList();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewReport_btn_Click(object sender, EventArgs e)
        {
            attReport_frm attR = new attReport_frm();
            attR.Show();
            
        }
    }
}

