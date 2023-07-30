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
    public partial class trainmaster : Form
    {
        string conString = "Data Source=LAPTOP-ONRAIVR5;Initial Catalog=project;Integrated Security=True";
        public trainmaster()
        {
            InitializeComponent();
        }

        private void trainmaster_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            trainmasterlogin h2 = new trainmasterlogin();
            h2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textcapacity.Text == "" || textname.Text == "" || textstatus.Text == "" || textbogie.Text == "" || textdestination.Text == "")
                MessageBox.Show("Please fill up all component !!");

            else
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                var CAPACITY = int.Parse(textcapacity.Text);
                string NAME = textname.Text;
                string STATUS = textstatus.Text;
                string BOGIE = textbogie.Text;
                string DESTINATION = textdestination.Text;

                string Queary = "INSERT INTO tmpage1 (NAME,CAPACITY,STATUS,BOGIE,DESTINATION) VALUES('" + NAME + "','" + CAPACITY + "','" + STATUS + "','" + BOGIE + "','" + DESTINATION + "') ";
                SqlCommand cmd = new SqlCommand(Queary, con);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Added !! ");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textcapacity.Text = textname.Text = textstatus.Text = textbogie.Text = textdestination.Text = "";
        }

        private void TMedit_Click(object sender, EventArgs e)
        {
            if (textcapacity.Text == "" || textname.Text == "" || textstatus.Text == "" || textbogie.Text == "" || textdestination.Text == "")
                MessageBox.Show("Please fill up all component !!");

            else
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand("Update tmpage1 set NAME = @NAME,CAPACITY = @CAPACITY,STATUS = @STATUS, BOGIE = @BOGIE, DESTINATION = @DESTINATION where NAME  =@NAME", con);

                cmd.Parameters.AddWithValue("@NAME", textname.Text);
                cmd.Parameters.AddWithValue("@CAPACITY", int.Parse(textcapacity.Text));
                cmd.Parameters.AddWithValue("@STATUS", textstatus.Text);
                cmd.Parameters.AddWithValue("@BOGIE", textbogie.Text);
                cmd.Parameters.AddWithValue("@DESTINATION", textdestination.Text);

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successfully Updated !! ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete tmpage1 where NAME  =@NAME", con);
            cmd.Parameters.AddWithValue("@NAME", textname.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Removed !! ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from tmpage1 where NAME  =@NAME", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@NAME", textname.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void TMshow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from tmpage1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
