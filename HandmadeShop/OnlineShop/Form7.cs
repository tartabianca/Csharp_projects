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
    public partial class Form7 : Form
    {
        User u;
        int id_order;
        int sum = 0;
        SqlConnection con = new SqlConnection();           
        
        public Form7(User u,int id_order)
        {
            InitializeComponent();
            this.u = u;
            this.id_order = id_order;
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            con.Open();
            String q = @"SELECT Orders.Id as NrComanda, Products.Nume as Produs, Products.Pret as PretProdus, SOrder.NumberOfProducts as NumarProduse
                        FROM ((Products INNER JOIN SOrder ON Products.Id = SOrder.Code_Product)
                        INNER JOIN Orders ON SOrder.Code_Order = Orders.Id)
                        WHERE Orders.Id='" + id_order + "'";
            SqlDataAdapter s = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            s.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            
            for (int i = 0; i < dataGridView1.RowCount; i++)
                sum = sum + Int32.Parse(dataGridView1[2, i].Value.ToString()) * Int32.Parse(dataGridView1[3, i].Value.ToString());
            label7.Text = "Valoarea totala a comenzii: " + sum + " RON";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(u);
            f2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4(u);
            f4.Show();
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

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Bold);
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Bold);
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Bold);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Regular);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Regular);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Regular);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Regular);
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            label6.Text = "Comanda ta a fost inregistrata.";
            label6.Visible = true;
            label7.Visible = false;
            dataGridView1.Visible = false;

            con.Open();
            String q = "UPDATE Orders set Sum='" + sum+ "'where Id='" + id_order + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

    }
}
