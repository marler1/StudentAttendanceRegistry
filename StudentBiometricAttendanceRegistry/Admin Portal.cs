using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentBiometricAttendanceRegistry
{
    public partial class Admin_Portal : Form
    {
        public Admin_Portal()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddLec_btn_Click(object sender, EventArgs e)
        {
            Add_Lecturer addlec = new Add_Lecturer();
            addlec.Show();
            this.Show();
        }
        private void addLec_btn_Click_1(object sender, EventArgs e)
        {
            Add_Lecturer addlec = new Add_Lecturer();
            addlec.Show();
            this.Show();
        }

        private void department_btn_Click(object sender, EventArgs e)
        {

        }

        private void regStudent_btn_Click(object sender, EventArgs e)
        {
            Register_Student reg = new Register_Student();
            reg.Show();
            this.Hide();
        }

        private void addUnit_btn_Click(object sender, EventArgs e)
        {
            unitName_cb addUnit = new unitName_cb();
            addUnit.Show();
            this.Hide();
        }

        private void adminLogout_btn_Click(object sender, EventArgs e)
        {
            Home_frm log = new Home_frm();
            log.Show();
            this.Hide();
        }

        private void addCourse_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSMS_Click(object sender, EventArgs e)
        {

            frm_message mess = new frm_message();
            mess.Show();
            this.Hide();

            //frm_sendSMS sms = new frm_sendSMS();
            //sms.Show();
            //this.Hide();
        
        }
    }
}
