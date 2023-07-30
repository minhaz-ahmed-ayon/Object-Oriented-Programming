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
    public partial class stationmaster : Form
    {
        string conString = "Data Source=LAPTOP-ONRAIVR5;Initial Catalog=project;Integrated Security=True";
        public stationmaster()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stationmasterlogin h2 = new Stationmasterlogin();
            h2.Show();
        }

        private void PMadd_Click(object sender, EventArgs e)
        {
            if (passname.Text == "" || passaddress.Text == "" || passphone.Text == "" || passgender.Text == "" || dateTimePicker1.Text == "" || trainname.Text == "" || traindestination.Text == "" || trainstatus.Text == "" || traincost.Text == "")
                MessageBox.Show("Please fill up all component !!");

            else
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                var COST = int.Parse(traincost.Text);
                string NAME = passname.Text;
                string TRAIN_STATUS = trainstatus.Text;
                string ADDRESS = passaddress.Text;
                string CONTACT = passphone.Text;
                string GENDER = passgender.Text;
                string DATE = dateTimePicker1.Text;
                string TRAIN_NAME = trainname.Text;
                string DESTINATION = traindestination.Text;

                string Queary = "INSERT INTO smpage1 (NAME,TRAIN_STATUS,ADDRESS,CONTACT,GENDER,DATE,TRAIN_NAME,DESTINATION,COST) VALUES('" + NAME + "','" + TRAIN_STATUS + "','" + ADDRESS + "','" + CONTACT + "','" + GENDER + "','" + DATE + "','" + TRAIN_NAME+ "','" + DESTINATION+ "','" + COST + "') ";
                SqlCommand cmd = new SqlCommand(Queary, con);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Added !! ");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            passname.Text = passaddress.Text = passphone.Text = passgender.Text = dateTimePicker1.Text = trainname.Text = traindestination.Text = trainstatus.Text =  traincost.Text = "";
        }

        private void PMedit_Click(object sender, EventArgs e)
        {
            if (passname.Text == "" || passaddress.Text == "" || passphone.Text == "" || passgender.Text == "" || dateTimePicker1.Text == "" || trainname.Text == "" || traindestination.Text == "" || trainstatus.Text == "" || traincost.Text == "")
                MessageBox.Show("Please fill up all component !!");

            else
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand("Update Smpage1 set NAME = @NAME,TRAIN_STATUS = @TRAIN_STATUS,ADDRESS = @ADDRESS,CONTACT = @CONTACT,GENDER = @GENDER ,DATE = @DATE,TRAIN_NAME = @TRAIN_NAME,DESTINATION = @DESTINATION,COST = @COST where NAME  =@NAME", con);

                cmd.Parameters.AddWithValue("@NAME", passname.Text);
                cmd.Parameters.AddWithValue("@TRAIN_STATUS", trainstatus.Text);
                cmd.Parameters.AddWithValue("@ADDRESS", passaddress.Text);
                cmd.Parameters.AddWithValue("@CONTACT", passphone.Text);
                cmd.Parameters.AddWithValue("@GENDER", passgender.Text);
                cmd.Parameters.AddWithValue("@DATE", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@TRAIN_NAME", trainname.Text);
                cmd.Parameters.AddWithValue("@DESTINATION", traindestination.Text);
                cmd.Parameters.AddWithValue("@COST", int.Parse(traincost.Text));


                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successfully Updated !! ");
            }
        }

        private void TMremove_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete smpage1 where NAME  =@NAME", con);
            cmd.Parameters.AddWithValue("@NAME", passname.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Removed !! ");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from smpage1 where NAME  =@NAME", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@NAME", passname.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void PassShow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from smpage1", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
