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
    public partial class stationmasterregistration : Form
    {
        string conString = "Data Source=LAPTOP-ONRAIVR5;Initial Catalog=project;Integrated Security=True";
        public stationmasterregistration()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stationmasterlogin sml2= new Stationmasterlogin();
            sml2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxname.Text == "" || textBoxaddress.Text == "" || textBoxcontact.Text == "" || textBoxusername.Text == "" || textBoxpassword.Text == "")
                MessageBox.Show("Please fill up all component !!");

            else
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string Name = textBoxname.Text;
                string Address = textBoxaddress.Text;
                string Contact = textBoxcontact.Text;
                string Username = textBoxusername.Text;
                string Password = textBoxpassword.Text;

                string Queary = "INSERT INTO smregistration (Name ,Address,Contact,Username,Password) VALUES('" + Name + "','" + Address + "','" + Contact + "', '" + Username + "','" + Password + "') ";
                SqlCommand cmd = new SqlCommand(Queary, con);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Added !! ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxname.Text == "" || textBoxaddress.Text == "" || textBoxcontact.Text == "" || textBoxusername.Text == "" || textBoxpassword.Text == "")
                MessageBox.Show("Please fill up all component !!");

            else
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand("Update smregistation set Name = @Name,Address = @Address,Contact = @Contact,Username= @Username,Password=@Password where Name  =@Name", con);

                cmd.Parameters.AddWithValue("@Name", textBoxname.Text);
                cmd.Parameters.AddWithValue("@Address", textBoxaddress.Text);
                cmd.Parameters.AddWithValue("@Contact", textBoxcontact.Text);
                cmd.Parameters.AddWithValue("@Username", textBoxusername.Text);
                cmd.Parameters.AddWithValue("@Password", textBoxpassword.Text);

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successfully Edited !! ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxname.Text = textBoxaddress.Text = textBoxcontact.Text = textBoxusername.Text = textBoxpassword.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete smregistration where Name  =@Name", con);
            cmd.Parameters.AddWithValue("@Name", textBoxname.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Delated successfully!!");
        }

        private void textBoxusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
