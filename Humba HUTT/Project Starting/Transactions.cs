﻿using System;
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
using System.IO;
namespace Starting_Form
{
    public partial class Transactions : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Transactions()
        {
            InitializeComponent();
            BindGridGrave();
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.Navy;
            button6.ForeColor = Color.White;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Navy;
            button1.ForeColor = Color.White;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.BackColor = Color.Navy;
            button7.ForeColor = Color.White;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Navy;
            button3.ForeColor = Color.White;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Navy;
            button4.ForeColor = Color.White;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Navy;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Navy;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.White;
            button7.ForeColor = Color.Navy;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
            button3.ForeColor = Color.Navy;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button4.ForeColor = Color.Navy;
        }
        void BindGridGrave()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from SELLER_TRAX";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            //data from db to gridview
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            /*

            DataGridViewImageColumn dvg = new DataGridViewImageColumn();
            dvg = (DataGridViewImageColumn)dataGridView1.Columns[3];
            dvg.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //AUTOSIZE*/

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 50;


        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           textBox7.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            //pictureBox16.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[5].Value);*/
            //textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            // textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            // textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox4.Text != "" && textBox7.Text != "")
            { 
                SqlConnection con = new SqlConnection(cs);
                string query = "delete from SELLER_TRAX where seller=@seller";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@seller", textBox2.Text);
               // cmd.Parameters.AddWithValue("@buyerphone", textBox4.Text);

                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Remove successful !!");
                    BindGridGrave();
                   ResetAuto();
                }
                else
                {
                    MessageBox.Show("Not Successful");

                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Fill The form 1st !!");
            }
           
        }
        void ResetAuto()
        {
            //textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox7.Clear();
            //textBox5.Clear();
            //textBox6.Clear();
            //pictureBox16.Image = Properties.Resources.cow__1_;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Log_In f1 = new Log_In();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Home f1 = new Admin_Home();
            f1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Admin_Bookings f1 = new Admin_Bookings();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_FAQ f1 = new Admin_FAQ();
            f1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_about_Us f1 = new Admin_about_Us();
            f1.Show();
            this.Hide();
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
    }
}
