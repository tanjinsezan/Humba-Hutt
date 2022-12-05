using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starting_Form
{
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
             Log_In f1 = new Log_In();
            f1.Show();
            this.Hide();
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.Navy;
            button6.ForeColor = Color.White;
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

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Navy;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Navy;
            button1.ForeColor = Color.White;
        }

        private void pictureBox16_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Navy;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Navy;
            button2.ForeColor = Color.White;
        }

        private void pictureBox17_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.Navy;
            button5.ForeColor = Color.White;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.Navy;
            button5.ForeColor = Color.White;
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            button8.BackColor = Color.Navy;
            button8.ForeColor = Color.White;
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            button8.BackColor = Color.Navy;
            button8.ForeColor = Color.White;
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            button9.BackColor = Color.Navy;
            button9.ForeColor = Color.White;
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            button9.BackColor = Color.Navy;
            button9.ForeColor = Color.White;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.White;
            button6.ForeColor = Color.Navy;
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

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Navy;
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Navy;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Navy;
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Navy;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
            button5.ForeColor = Color.Navy;
        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
            button5.ForeColor = Color.Navy;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.White;
            button8.ForeColor = Color.Navy;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.White;
            button8.ForeColor = Color.Navy;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.White;
            button9.ForeColor = Color.Navy;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.White;
            button9.ForeColor = Color.Navy;
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

        private void button7_Click(object sender, EventArgs e)
        {
            Admin_Bookings f1 = new Admin_Bookings();
            f1.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buyer_List f1 = new Buyer_List();
            f1.Show();
            this.Hide();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Buyer_List f1 = new Buyer_List();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_List f1 = new Admin_List();
            f1.Show();
            this.Hide();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Admin_List f1 = new Admin_List();
            f1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Seller_List f1 = new Seller_List();
            f1.Show();
            this.Hide();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Seller_List f1 = new Seller_List();
            f1.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Admin_Cow_List f1 = new Admin_Cow_List();
            f1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Admin_Cow_List f1 = new Admin_Cow_List();
            f1.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Admin_Goat_List f1 = new Admin_Goat_List();
            f1.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Admin_Goat_List f1 = new Admin_Goat_List();
            f1.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Transactions f1 = new Transactions();
            f1.Show();
            this.Hide();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Transactions f1 = new Transactions();
            f1.Show();
            this.Hide();
        }

        private void button11_MouseHover(object sender, EventArgs e)
        {
            button11.BackColor = Color.Navy;
            button11.ForeColor = Color.White;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.White;
            button11.ForeColor = Color.Navy;
        }

        private void pictureBox19_MouseHover(object sender, EventArgs e)
        {
            button11.BackColor = Color.Navy;
            button11.ForeColor = Color.White;
        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            button11.BackColor = Color.White;
            button11.ForeColor = Color.Navy;
        }
    }
}
