using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    public partial class Form4 : Form
    {
        User u;
        SqlConnection con = new SqlConnection();        
        
        public Form4(User u)
        {
            InitializeComponent();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            this.u = u;
        }

        

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Bold);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, FontStyle.Bold);
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Bold);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Regular);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Regular);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, FontStyle.Regular);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Regular);
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            con.Open();
            DataSet dsOrders = new DataSet();
            SqlDataAdapter daOrders = new SqlDataAdapter("select OrderDate, Sum from Orders where Code_user ='" + u.getId() + "'", con);
            daOrders.Fill(dsOrders, "Orders");
            foreach (DataRow dr in dsOrders.Tables["Orders"].Rows)
            {
                string date = DateTime.Parse(dr.ItemArray.GetValue(0).ToString()).ToShortDateString(); ;
                string sum=dr.ItemArray.GetValue(1).ToString();
                listBox1.Items.Add(date + " - " + sum +" RON");
                
            }
            con.Close();
            if (listBox1.Visible == true)
                listBox1.Visible = false;
            else
                listBox1.Visible = true;
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            radioButton1.AutoCheck = true;
            radioButton2.AutoCheck = true;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            button_WOC1.Visible = false;
            button_WOC3.Visible = true;
            

        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            u.setFirstName(textBox1.Text);
            u.setLastName(textBox2.Text);
            u.setMail(textBox3.Text);
            u.setDate(Convert.ToDateTime(textBox4.Text));
            if (radioButton1.Checked)
                u.setGender("male");
            else
                u.setGender("female");

            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            con.Open();
            String q = "update Users set FirstName='" + u.getFirstName() + "',LastName='" + u.getLastName() + "',Mail='" + u.getMail() + "',DateOfBirth='" + u.getDate() + "',Gender='" + u.getGender() + "' where Id='" + u.getId() + "'";
           
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();

            radioButton1.AutoCheck = true;
            radioButton2.AutoCheck = false;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            button_WOC1.Visible = true;
            button_WOC3.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(u);
            f2.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con.Open();
            DataSet dsUsers = new DataSet();
            SqlDataAdapter daUsers = new SqlDataAdapter("select * from Users where Id='" + u.getId() + "' ", con);
            daUsers.Fill(dsUsers, "Users");
            foreach (DataRow dr in dsUsers.Tables["Users"].Rows)
            {
                textBox1.Text = dr.ItemArray.GetValue(1).ToString();
                textBox2.Text = dr.ItemArray.GetValue(2).ToString();
                textBox3.Text = dr.ItemArray.GetValue(3).ToString();
                textBox4.Text = DateTime.Parse(dr.ItemArray.GetValue(5).ToString()).ToShortDateString();
                String g = dr.ItemArray.GetValue(6).ToString();
                if (g.ToLower() == "m")
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;

            }
            con.Close();

            con.Open();
            String q= "select * from Users";
            SqlDataAdapter s = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            s.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            
            con.Open();
            q = "delete Orders where Sum='"+0+"'";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5(u);
            f5.Show();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
