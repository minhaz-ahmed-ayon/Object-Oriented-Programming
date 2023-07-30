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
    public partial class trainmasterregistration : Form
    {
        string conString = "Data Source=LAPTOP-ONRAIVR5;Initial Catalog=project;Integrated Security=True";
        public trainmasterregistration()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            trainmasterlogin tml2 = new trainmasterlogin();
            tml2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" || textAddress.Text == "" || textContact.Text == ""|| textUsername.Text == "" || textPassword.Text == "")
                MessageBox.Show("Please fill up all component !!");

            else
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                string Name = textName.Text;
                string Address = textAddress.Text;
                string Contact = textContact.Text;
                string Username = textUsername.Text;
                string Password = textPassword.Text;

                string Queary = "INSERT INTO tmregistation (Name ,Address,Contact,Username,Password) VALUES('" + Name + "','" +Address + "','" +Contact+ "', '" + Username + "','" +Password+ "') ";
                SqlCommand cmd = new SqlCommand(Queary, con);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Added !! ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" || textAddress.Text == "" || textContact.Text == "" || textUsername.Text == "" || textPassword.Text == "")
                MessageBox.Show("Please fill up all component !!");

            else
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand("Update tmregistation set Name = @Name,Address = @Address,Contact = @Contact,Username= @Username,Password=@Password where Name  =@Name", con);

                cmd.Parameters.AddWithValue("@Name", textName.Text);
                cmd.Parameters.AddWithValue("@Address", textAddress.Text);
                cmd.Parameters.AddWithValue("@Contact", textContact.Text);
                cmd.Parameters.AddWithValue("@Username", textUsername.Text);
                cmd.Parameters.AddWithValue("@Password", textPassword.Text);

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successfully Edited !! ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textName.Text = textAddress.Text = textContact.Text = textUsername.Text = textPassword.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete tmregistation where Name  =@Name", con);
            cmd.Parameters.AddWithValue("@Name", textName.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Delated successfully!!");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
