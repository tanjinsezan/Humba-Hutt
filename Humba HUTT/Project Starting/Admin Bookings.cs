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
    public partial class Admin_Bookings : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Admin_Bookings()
        {
            InitializeComponent();
            BindGridGrave();
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.Navy;
            button6.ForeColor = Color.White;
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            button10.BackColor = Color.Navy;
            button10.ForeColor = Color.White;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.BackColor = Color.Navy;
            button7.ForeColor = Color.White;
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

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.BackColor = Color.White;
            button10.ForeColor = Color.Navy;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.White;
            button7.ForeColor = Color.Navy;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button4.ForeColor = Color.Navy;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Admin_Home f1 = new Admin_Home();
            f1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Admin_FAQ f1 = new Admin_FAQ();
            f1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Log_In f1 = new Log_In();
            f1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_about_Us f1 = new Admin_about_Us();
            f1.Show();
            this.Hide();
        }
        void BindGridGrave()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from BOOKING_LIST";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            //data from db to gridview
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;


            DataGridViewImageColumn dvg = new DataGridViewImageColumn();
            dvg = (DataGridViewImageColumn)dataGridView1.Columns[3];
            dvg.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //AUTOSIZE

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 50;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "delete from BOOKING_LIST where phone=@phone";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@phone", textBox4.Text);
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
        void ResetAuto()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            
            pictureBox16.Image = Properties.Resources.cow__1_;

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            pictureBox16.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[3].Value);
        }
        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "" && textBox6.Text != "")
            {
                int num1 = int.Parse(textBox5.Text);
                int num2 = int.Parse(textBox6.Text);
                int result = num1 - num2;
                textBox7.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please Fill The Amount First !!");
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into SELLER_TRAX values (@price,@fees,@income,@buyerphone,@seller)";

                SqlCommand cmd = new SqlCommand(query, con);


                cmd.Parameters.AddWithValue("@price", textBox5.Text);
                cmd.Parameters.AddWithValue("@fees", textBox6.Text);
                cmd.Parameters.AddWithValue("@income", textBox7.Text);
                cmd.Parameters.AddWithValue("@seller", textBox2.Text);
                cmd.Parameters.AddWithValue("@buyerphone", textBox4.Text);

                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Added Successfully");
                   
                    //BindGridGrave();
                    ResetAuto();
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

        private void button9_MouseHover(object sender, EventArgs e)
        {
            button9.BackColor = Color.Navy;
            button9.ForeColor = Color.White;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.White;
            button9.ForeColor = Color.Navy;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
             int x = 100, y = 100; 
       

            var header = new Font("Calibri", 21, FontStyle.Bold);
            int hdy = (int)header.GetHeight(e.Graphics); //30; //line height 

            var fnt = new Font("Times new Roman", 14, FontStyle.Bold);
            int dy = (int)fnt.GetHeight(e.Graphics); //20; //line height spacing

            string nowDateTime = "" + DateTime.Now.ToString("D");
            //Console.WriteLine(nowDateTime);


            e.Graphics.DrawString("---------------------.Hamba Hatt !!----------------------.", header, Brushes.Black, new PointF(x, y)); y += hdy + hdy + hdy;
            e.Graphics.DrawString("                   "+nowDateTime, header, Brushes.Black, new PointF(x, y)); y += hdy + hdy + hdy;
            e.Graphics.DrawString("-----------------Transection Details -------------------", header, Brushes.Black, new PointF(x, y)); y += hdy + hdy + hdy;
            e.Graphics.DrawString("Seller Id------------------" + textBox2.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
            e.Graphics.DrawString("Asking Price-------------" + textBox5.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
            e.Graphics.DrawString("Hamba Hatt Fee--------" + textBox6.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
            e.Graphics.DrawString("__________________________________________________________", header, Brushes.Black, new PointF(x, y)); y += hdy + hdy + hdy;
            e.Graphics.DrawString("Seller Total Income----" + textBox7.Text, fnt, Brushes.Black, new PointF(x, y)); y += dy;
            e.Graphics.DrawString("                                                          ", header, Brushes.Black, new PointF(x, y)); y += hdy + hdy + hdy;
   
            e.Graphics.DrawString("Seller Account Number :-" + textBox8.Text, fnt, Brushes.Black, new PointF(x, y)); y += hdy + hdy + hdy;
            e.Graphics.DrawString("Buyer Phone No :-" + textBox4.Text, fnt, Brushes.Black, new PointF(x, y)); y += hdy + hdy + hdy;
            e.Graphics.DrawString("        Thanks for Being With HAMBA HATT !! ", header, Brushes.Black, new PointF(x, y)); y += hdy + hdy + hdy;

           


          
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
