using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    
    public partial class Form2 : Form
    {
        int ct = 0;
        User u;
        
        public Form2(User u)
        {
            InitializeComponent();
            timer1.Start();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
            this.u = u;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox5.Image = imageList1.Images[ct % 9];
            ct++;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Bold);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Regular);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5(u);
            f5.Show();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Bold);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Regular);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, FontStyle.Bold);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, FontStyle.Regular);
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Bold);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Regular);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4(u);
            f4.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6(u);
            f6.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cosul tau e gol!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
