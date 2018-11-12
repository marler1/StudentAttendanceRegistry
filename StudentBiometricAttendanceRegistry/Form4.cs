using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentBiometricAttendanceRegistry
{
    public partial class attReport_frm : Form
    {
        public attReport_frm(string course, string unit)
        {
            InitializeComponent();
            lblCourse.Text = course;
            lblUnit.Text = unit;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Doc_printPage(object sender, PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(this.panelPrint.Width, this.panelPrint.Height);
            this.panelPrint.DrawToBitmap(bmp, new Rectangle(0, 0, this.panelPrint.Width, this.panelPrint.Height));
            e.Graphics.DrawImage((Image) bmp,x,y);
        }

        private void loadList()
        {
            
            try
            {
                DateTime tm = DateTime.Now;
                string tday = tm.ToString("yyyy-MM-dd");
                string sql23 = "SELECT date,  RegistrationNumber, fName, lName, counter FROM attendance";
                string conn = "Server=127.0.0.1; SslMode=none; port=3306; Uid=root; Database=Studentdb; Password=";


                using (MySqlConnection sqlcon3 = new MySqlConnection(conn))
                {
                    MySqlDataAdapter adapt = new MySqlDataAdapter(sql23, sqlcon3);
                    DataTable dyta = new DataTable();
                    adapt.Fill(dyta);
                    dataGridView1.DataSource = dyta;
                    sqlcon3.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }



        }


        private void print_btn_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.Doc_printPage;
            PrintDialog dlgSet = new PrintDialog();
            dlgSet.Document = doc;
            if (dlgSet.ShowDialog() == DialogResult.OK) {
                doc.Print();
            }

            
        }

        private void attReport_frm_Load(object sender, EventArgs e)
        {
            loadList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
