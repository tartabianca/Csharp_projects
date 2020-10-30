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

namespace Utilizator
{
    public partial class Form1 : Form
    {
        Utilizator.ServiceReference1.WebService1SoapClient service = new Utilizator.ServiceReference1.WebService1SoapClient();

        public Form1()
        {
            InitializeComponent();
                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Text = "";
            List<String> prods=new List<String>();
            prods = service.selectdb(comboBox1.SelectedItem.ToString());
            int sizeOfList = prods.Count;
            for (int i = 0; i < sizeOfList; i++)
                listBox1.Items.Add(prods[i]);
        }

        private void insert_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;

        }

        private void ok_insert_Click(object sender, EventArgs e)
        {
            
            bool ok = service.insertDB(Int32.Parse(insert_id.Text), insert_prod.Text, Int32.Parse(insert_no.Text),float.Parse(insert_price.Text), insert_shop.Text);
            this.Hide();
            Form f1 = new Form1();
            f1.Show();
            
        }

        private void update_Click(object sender, EventArgs e)
        {
        
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            
        }

        private void ok_update_Click(object sender, EventArgs e)
        {
            
            bool ok = service.updateDB(listBox1.SelectedItem.ToString(), comboBox1.SelectedItem.ToString(), Int32.Parse(update_id.Text), update_prod.Text, Int32.Parse(update_no.Text), float.Parse(update_price.Text), update_shop.Text);
            this.Hide();
            Form f1 = new Form1();
            f1.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<String> prod = new List<String>();
            prod = service.selectAnItem(comboBox1.SelectedItem.ToString(), listBox1.SelectedItem.ToString());
            update_id.Text = prod[0];
            update_prod.Text = prod[1];
            update_no.Text = prod[2];
            update_price.Text = prod[3];
            update_shop.Text = prod[4];
        }

        private void delete_Click(object sender, EventArgs e)
        {
            service.deleteDB(listBox1.SelectedItem.ToString(), comboBox1.SelectedItem.ToString());
            this.Hide();
            Form f1 = new Form1();
            f1.Show();
        }
    }
}
