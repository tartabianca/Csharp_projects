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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        User u;
        
        public Form1()
        {
            InitializeComponent();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            String mail, pass;
            bool ok=false;
            mail = textBox1.Text;
            pass = textBox2.Text;

            con.Open();
            DataSet dsUsers = new DataSet();
            SqlDataAdapter daUsers = new SqlDataAdapter("select * from Users where Mail='" + mail + "' and Password='" + pass + "'", con); 
            daUsers.Fill(dsUsers, "Users");
            foreach (DataRow dr in dsUsers.Tables["Users"].Rows)
            {
                int id = Int32.Parse(dr.ItemArray.GetValue(0).ToString());
                String fn = dr.ItemArray.GetValue(1).ToString();
                String ln = dr.ItemArray.GetValue(2).ToString();
                String m = dr.ItemArray.GetValue(3).ToString();
                String p = dr.ItemArray.GetValue(4).ToString();
                DateTime d = DateTime.Parse(dr.ItemArray.GetValue(5).ToString());
                String g = dr.ItemArray.GetValue(6).ToString();
                u = new User(id, fn, ln, m, p, d, g);
                this.Hide();
                Form2 f2 = new Form2(u);
                f2.Show();
                ok = true;
            }
            con.Close();

             if(ok==false)
               MessageBox.Show("Ai gresit utilizatorul sau parola!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
            textBox2.PasswordChar ='*';
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Font=new Font( label1.Font,FontStyle.Bold^FontStyle.Underline);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Underline^FontStyle.Bold^FontStyle.Italic);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
