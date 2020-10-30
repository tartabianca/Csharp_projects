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
    public partial class Form5 : Form
    {
        User u;
        int id_order;
        SqlConnection con = new SqlConnection();          
        
        public Form5(User u)
        {
            InitializeComponent();
            this.u = u;
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

            Random rnd = new Random();
            id_order = rnd.Next(1000, 9999);
            numericUpDown1.Value = 1;
        }
       

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Bold);
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

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Regular);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, FontStyle.Regular);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Regular);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(u);
            f2.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            con.Open();
            String q = "select Id, Nume, Pret from Products";
            SqlDataAdapter s = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            s.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            con.Open();
            q = "insert into Orders values('" + id_order + "','" + u.getId() + "','" + 0 + "','" + DateTime.Now.ToString("yyyy-MM-dd")+ "')";
            SqlCommand cmd = new SqlCommand(q, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4(u);
            f4.Show();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count==0)
                MessageBox.Show("Alege produsul dorit din lista!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (numericUpDown1.Value == 0)
                  MessageBox.Show("Cate produse doriti?", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Random rnd = new Random();
                int id = rnd.Next(1000, 9999);
                int no = Int32.Parse(numericUpDown1.Value.ToString());
                String id_produs = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                con.Open();
                String q = "insert into SOrder values('" + id + "','" + id_produs + "','" + id_order + "','" + no + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                int i = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Produsul a fost adaugat in Cos!", "<3", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            numericUpDown1.Value = 1;
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("Alege cate un produsul dorit pentru a-l adauga in lista!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int ProductExist = 0;
                String id_produs = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                con.Open();
                SqlCommand check_Product = new SqlCommand("select count(*) from Wishlist where Code_product ='" + id_produs + "' and Code_user ='" + u.getId() + "'", con);
                ProductExist = (int)check_Product.ExecuteScalar();
                con.Close();

                if (ProductExist!=0)
                    MessageBox.Show("Produsul se regaseste deja in Wishlist!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Random rnd = new Random();
                    int id = rnd.Next(1000, 9999);
                    con.Open();
                    String qq = "insert into Wishlist values('" + id + "','" + u.getId() + "','" + id_produs + "')";
                    SqlCommand cmd = new SqlCommand(qq, con);
                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Produsul a fost adaugat in WishList!", "<3", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6(u);
            f6.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7(u,id_order);
            f7.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }


    }
}
