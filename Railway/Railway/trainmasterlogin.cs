using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Railway
{
    public partial class trainmasterlogin : Form
    {
        string conString = "Data Source=LAPTOP-ONRAIVR5;Initial Catalog=project;Integrated Security=True";
        public trainmasterlogin()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f1 = new Home();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            trainmasterregistration tmr1 = new trainmasterregistration();
            tmr1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string Queary = "Select * from tmregistation where Username='" + textuser.Text.Trim() + "' and Password ='" + textpass.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(Queary, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                trainmaster tmh1 = new trainmaster();
                tmh1.Show();

            }
            else
            {
                MessageBox.Show("Check your username and Password");
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxshow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxshow.Checked)
            {
                textpass.PasswordChar = '\0';
            }
            else
            {
                textpass.PasswordChar = '*';

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
