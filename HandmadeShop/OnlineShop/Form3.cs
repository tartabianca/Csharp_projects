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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection();
        public Form3()
        {
            InitializeComponent();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == ""
                || (radioButton1.Checked == false && radioButton2.Checked == false) || comboBox1.SelectedItem.ToString()=="")
                MessageBox.Show("Toate campurile sunt obligatorii!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (!textBox4.Text.Equals(textBox5.Text))
                MessageBox.Show("Parolele nu coincid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Random rnd = new Random();
                int id = rnd.Next(1000, 9999);
                String fn = textBox1.Text;
                String ln = textBox2.Text;
                String m = textBox3.Text;
                String p = textBox4.Text;
                DateTime d = Convert.ToDateTime((comboBox1.SelectedIndex + 1).ToString() + "/"+ textBox6.Text + "/" + textBox7.Text);
                String g;
                if (radioButton1.Checked)
                    g = "m";
                else
                    g = "f";
                con.Open();
                String q = "insert into [Users] values('" + id + "','" + fn + "','" + ln + "','" + m + "','" + p + "','" + d + "','" + g + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                con.Close();

                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
                }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
