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
    public partial class Stationmasterlogin : Form
    {
        string conString = "Data Source=LAPTOP-ONRAIVR5;Initial Catalog=project;Integrated Security=True";
        public Stationmasterlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            string Queary = "Select * from smregistration where Username='" + textBoxUsername.Text.Trim() + "' and Password ='" + textBoxPassword.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(Queary, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                stationmaster smh1 = new stationmaster();
                smh1.Show();

            }
            else
            {
                MessageBox.Show("Check your username and Password");
            }

            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h2 = new Home();
            h2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            stationmasterregistration smr1 = new stationmasterregistration();
            smr1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void checkBoxpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpass.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
