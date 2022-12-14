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
    public partial class Cart_Buyer : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Cart_Buyer()
        {
            InitializeComponent();
            BindGridGrave();
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.Navy;
            button6.ForeColor = Color.White;
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

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Navy;
            button2.ForeColor = Color.White;
            button7.Visible = true;
            button8.Visible = true;
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

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Navy;
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

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Navy;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.BackColor = Color.Navy;
            button7.ForeColor = Color.White;

        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            button8.BackColor = Color.Navy;
            button8.ForeColor = Color.White;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.White;
            button7.ForeColor = Color.Navy;
            button7.Visible = false;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.White;
            button8.ForeColor = Color.Navy;
            button8.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Log_In f1 = new Log_In();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FAQ_Buyer f1 = new FAQ_Buyer();
            f1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            About_Us f1 = new About_Us();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cows_List f1 = new Cows_List();
            f1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Goats_List f1 = new Goats_List();
            f1.Show();
            this.Hide();
        }

        void BindGridGrave()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from CART_LIST";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            //data from db to gridview
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;


            DataGridViewImageColumn dvg = new DataGridViewImageColumn();
            dvg = (DataGridViewImageColumn)dataGridView1.Columns[5];
            dvg.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //AUTOSIZE

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 50;

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            pictureBox16.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[5].Value);
            //textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
           // textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
           // textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into BOOKING_LIST values (@price,@seller,@weight,@picture,@id)";
                
                SqlCommand cmd = new SqlCommand(query, con);


                cmd.Parameters.AddWithValue("@weight", textBox3.Text);
                cmd.Parameters.AddWithValue("@price", textBox1.Text);
                cmd.Parameters.AddWithValue("@picture", SavePhoto());
                cmd.Parameters.AddWithValue("@seller", textBox2.Text);
                cmd.Parameters.AddWithValue("@id", textBox4.Text);

                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    button11.Visible = true;
                   
                    MessageBox.Show("Please Press Confirm To Complete Booking");
                  ;
                   
                   // query = "delete from CART_LIST where price=@price";
                    BindGridGrave();
                    //ResetAuto();
                }
                else
                {
                    MessageBox.Show("Error Adding");

                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Please Fill The form 1st !!");
            }
        }
        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox16.Image.Save(ms, pictureBox16.Image.RawFormat);
            return ms.GetBuffer();
        }
        void ResetAuto()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
           // textBox5.Clear();
           // textBox6.Clear();
            pictureBox16.Image = Properties.Resources.cow__1_;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "delete from CART_LIST where id=@id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", textBox2.Text);
                //cmd.Parameters.AddWithValue("@price", textBox5.Text);

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

        private void button10_MouseHover(object sender, EventArgs e)
        {
            button10.BackColor = Color.Navy;
            button10.ForeColor = Color.White;
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            button9.BackColor = Color.Navy;
            button9.ForeColor = Color.White;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.White;
            button10.ForeColor = Color.Navy;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.White;
            button9.ForeColor = Color.Navy;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "delete from CART_LIST where id=@id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", textBox2.Text);
                //cmd.Parameters.AddWithValue("@price", textBox5.Text);

                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Booking Successful");
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

        
    }
}
