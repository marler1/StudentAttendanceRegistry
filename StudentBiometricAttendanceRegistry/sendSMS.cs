using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.IO;


namespace StudentBiometricAttendanceRegistry
{
    public partial class frm_sendSMS : Form
    {
        public frm_sendSMS()
        {
            InitializeComponent();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            {
                String result;
                string apiKey = txtKey.Text;
                string numbers = txtNum.Text; // in a comma seperated list
                string message =txtmessage.Text;
                string send = txtSender.Text;

                String url = "https://api.txtlocal.com/send/?apikey=" + apiKey + "&numbers=" + numbers + "&message=" + message + "&sender=" + send;
                //refer to parameters to complete correct url string

                StreamWriter myWriter = null;
                HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);

                objRequest.Method = "POST";
                objRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
                objRequest.ContentType = "application/x-www-form-urlencoded";
                try
                {
                    myWriter = new StreamWriter(objRequest.GetRequestStream());
                    myWriter.Write(url);
                }
                catch (Exception ex)
                {
                    // return e.Message;
                    MessageBox.Show(null, "the error is "+ ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    myWriter.Close();
                }

                HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
                using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                    // Close and clean up the StreamReader
                    sr.Close();
                }
                // return result;
                MessageBox.Show( result);
                //clear text boxes
                txtKey.Text = "";
                txtmessage.Text = "";
                txtNum.Text = "";
                txtSender.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Portal ad = new Admin_Portal();
            ad.Show();
            this.Hide();
        }
    }
}
