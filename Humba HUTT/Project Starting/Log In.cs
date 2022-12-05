using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Starting_Form
{
    public partial class Log_In : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Log_In()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Navy;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Navy;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Navy;
            button4.ForeColor = Color.White;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Navy;
            button3.ForeColor = Color.White;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
            button3.ForeColor = Color.Navy;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text!="")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from ADMIN_LIST where name=@name and pass=@pass";
                SqlCommand cmd = new SqlCommand(query,con);

                cmd.Parameters.AddWithValue("@name",textBox1.Text);
                cmd.Parameters.AddWithValue("@pass",textBox2.Text);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows==true)
                {
                    Admin_Home f1 = new Admin_Home();
                             f1.Show();
                             this.Hide();
                }
                else
                {
                    MessageBox.Show("Log In Failed . Please Enter Name Password Correctly ");
                }

                con.Close();

            }
            else
            {
                MessageBox.Show("Enter Name Password 1st !! ");
            }




         
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Navy;
            button2.ForeColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button4.ForeColor = Color.Navy;
           
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Navy;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider1.Icon = Properties.Resources.wrong_close_remove_icon_176368;
                errorProvider1.SetError(this.textBox1, "Enter Name 1st!");
            }
            else
            {
                errorProvider1.Icon = Properties.Resources.correct_apply_done_icon_176355;
                //errorProvider1.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                errorProvider2.Icon = Properties.Resources.wrong_close_remove_icon_176368;
                errorProvider2.SetError(this.textBox2, "Enter Password 1st!");
            }
            else
            {
                errorProvider2.Icon = Properties.Resources.correct_apply_done_icon_176355;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          bool status= checkBox1.Checked;
            switch(status)
            {
                case true:
                    textBox2.UseSystemPasswordChar=false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sign_In_First f1 = new Sign_In_First();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from BUYER_LIST where name=@name and pass=@pass";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Log In Failed . Please Enter Name Password Correctly ");
                    textBox1.Clear();
                    textBox2.Clear();
                }

                con.Close();

            }
            else
            {
                MessageBox.Show("Enter Name Password 1st !! ");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from SELLER_LIST where name=@name and pass=@pass";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {

                    Seller f1 = new Seller();
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Log In Failed . Please Enter Name Password Correctly ");
                    textBox1.Clear();
                    textBox2.Clear();
                }

                con.Close();

            }
            else
            {
                MessageBox.Show("Enter Name Password 1st !! ");
            }

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.Navy;
            button5.ForeColor = Color.White;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
            button5.ForeColor = Color.Navy;
        }

    }
}
