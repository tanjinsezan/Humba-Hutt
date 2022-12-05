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
using System.IO;

namespace Starting_Form
{
    public partial class My_Product_Seller : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public My_Product_Seller()
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

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.Navy;
            button5.ForeColor = Color.White;
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

        private void button5_MouseLeave(object sender, EventArgs e)
        {
             button5.BackColor = Color.White;
            button5.ForeColor = Color.Navy;
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

        private void button6_Click(object sender, EventArgs e)
        {
            Log_In f1 = new Log_In();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seller f1 = new Seller();
            f1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bookings_Seller f1 = new Bookings_Seller();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FAQ_Seller f1 = new FAQ_Seller();
            f1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            About_Us_Seller f1 = new About_Us_Seller();
            f1.Show();
            this.Hide();
        }

        void BindGridGrave()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from COW_LIST";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            //data from db to gridview
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            

            DataGridViewImageColumn dvg = new DataGridViewImageColumn();
            dvg = (DataGridViewImageColumn)dataGridView1.Columns[5];
            dvg.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //AUTOSIZE*/

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 50;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from COW_LIST where id like '"+this.textBox2.Text+"%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            dataGridView1.Visible = true;
            label6.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from GOAT_LIST where id like '" + this.textBox2.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;


            dataGridView1.Visible = true;
            label7.Visible = true;

        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.BackColor = Color.Navy;
            button7.ForeColor = Color.White;
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            button9.BackColor = Color.Navy;
            button9.ForeColor = Color.White;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.White;
            button7.ForeColor = Color.Navy;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.White;
            button9.ForeColor = Color.Navy;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from COW_LIST where id=@id";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", textBox7.Text);
            //cmd.Parameters.AddWithValue("@price", textBox5.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("REMOVE successful !!");
                BindGridGrave(); dataGridView1.Visible = false;
                label6.Visible = false;
                ResetAuto();

            }
            else
            {
                MessageBox.Show("REMOVE Not Successful");

            }
            con.Close();
        }
        void ResetAuto()
        {
          textBox2.Clear();
            textBox7.Clear();
           // textBox3.Clear();
           // textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from GOAT_LIST where id=@id";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", textBox7.Text);
            //cmd.Parameters.AddWithValue("@price", textBox5.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("REMOVE successful !!");
                BindGridGrave(); dataGridView1.Visible = false;
                label7.Visible = false;
                //BindGridGrave();
                ResetAuto();
            }
            else
            {
                MessageBox.Show("REMOVE Not Successful");

            }
            con.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }

