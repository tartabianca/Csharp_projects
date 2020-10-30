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
    public partial class Form6 : Form
    {
        User u;
        SqlConnection con = new SqlConnection();     
        
        public Form6(User u)
        {
            InitializeComponent();
            this.u = u;
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            int[] ids=new int[100];
            int i = 0;

            con.Open();
            DataSet dsIds = new DataSet();
            SqlDataAdapter daIds = new SqlDataAdapter("select Code_product from Wishlist where Code_user ='" + u.getId() + "'", con);
            daIds.Fill(dsIds, "Wishlist");
            foreach (DataRow dr in dsIds.Tables["Wishlist"].Rows)
            {
                int id = Int32.Parse(dr.ItemArray.GetValue(0).ToString());
                ids[i] = id;
                i++;  
            }
            con.Close();

            con.Open();
            DataSet dsProducts = new DataSet();
            SqlDataAdapter daProducts = new SqlDataAdapter("select Id, Nume, Pret from Products ", con);
            daProducts.Fill(dsProducts, "Products");
            foreach (DataRow dr in dsProducts.Tables["Products"].Rows)
            {
                int id = Int32.Parse(dr.ItemArray.GetValue(0).ToString());
                String name = dr.ItemArray.GetValue(1).ToString();
                String price = dr.ItemArray.GetValue(2).ToString();
                for (int j = 0; j < ids.Length; j++)
                    if (ids[j] == id)
                        listBox1.Items.Add(name + " - " + price + " RON");
            }
            con.Close();
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

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, FontStyle.Bold);
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

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, FontStyle.Regular);
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

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
                MessageBox.Show("Alege mai intai produsul!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                String s = listBox1.SelectedItem.ToString();
                int ss = s.IndexOf(" ");
                String p = s.Remove(ss, s.Length - ss);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                int id = 0;
                con.Open();
                DataSet dsP = new DataSet();
                SqlDataAdapter daP = new SqlDataAdapter("select Id from Products where Nume ='" + p + "'", con);
                daP.Fill(dsP, "Products");
                foreach (DataRow dr in dsP.Tables["Products"].Rows)
                {
                    id = Int32.Parse(dr.ItemArray.GetValue(0).ToString());

                }
                con.Close();

                con.Open();
                String q = "delete from Wishlist where Code_product='" + id + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cosul tau e gol!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
