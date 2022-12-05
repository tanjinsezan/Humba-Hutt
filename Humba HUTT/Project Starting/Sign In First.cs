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
    public partial class Sign_In_First : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Sign_In_First()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Log_In f1 = new Log_In();
            f1.Show();
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

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.Focus();
                errorProvider3.Icon = Properties.Resources.wrong_close_remove_icon_176368;
                errorProvider3.SetError(this.textBox3, "For Contact and Verification Please Provide Mobile No!");
            }
            else
            {
                errorProvider3.Icon = Properties.Resources.correct_apply_done_icon_176355;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.Focus();
                errorProvider4.Icon = Properties.Resources.wrong_close_remove_icon_176368;
                errorProvider4.SetError(this.textBox4, "For Contact Purpose Please Provide Address!");
            }
            else
            {
                errorProvider4.Icon = Properties.Resources.correct_apply_done_icon_176355;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;

            }
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

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Navy;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Navy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into BUYER_LIST values (@name,@pass,@mobile,@address,@email)";
                SqlCommand cmd = new SqlCommand(query, con);
                //cmd.Parameters.AddWithValue("@id", textBox6.Text);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                cmd.Parameters.AddWithValue("@mobile", textBox3.Text);
                cmd.Parameters.AddWithValue("@address", textBox4.Text);
                cmd.Parameters.AddWithValue("@email", textBox5.Text);


                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Congratulations !! You have successfully added to our Hamba Hatt!! family as a Buyer");
                    //BindGridGrave();
                    ResetAuto();
                }
                else
                {
                    MessageBox.Show("Sorry Your Data not incerted. Please try again later. THANK YOU");
                 
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Ups!! Could You please Fill the from properly and try again!! THANK YOU");
            }

        }
        /*void BindGridGrave()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from ADMIN_LIST";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            //data from db to gridview
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;


        }*/

        void ResetAuto()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into SELLER_LIST values (@name,@pass,@mobile,@address,@email)";
                SqlCommand cmd = new SqlCommand(query, con);
                //cmd.Parameters.AddWithValue("@id", textBox6.Text);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                cmd.Parameters.AddWithValue("@mobile", textBox3.Text);
                cmd.Parameters.AddWithValue("@address", textBox4.Text);
                cmd.Parameters.AddWithValue("@email", textBox5.Text);


                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Congratulations !! You have successfully added to our Hamba Hatt!! family as a Seller");
                    //BindGridGrave();
                    ResetAuto();
                }
                else
                {
                    MessageBox.Show("Sorry Your Data not incerted. Please try again later. THANK YOU");

                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Ups!! Could You please Fill the from properly and try again!! THANK YOU");
            }
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
    }
}
