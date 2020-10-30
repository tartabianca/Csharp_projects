using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Shops
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        List<String> prods; 
        
        [WebMethod]
        public bool insertDB(int id, String Name,int No,float Price, String Shop)
        {
            bool t = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            con.Open();
            String q = "insert into [Products] values('" + id + "','" + Name + "','" + No + "','" + Price + "','" + Shop + "')";
            SqlCommand cmd = new SqlCommand(q, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
                t = true;
            return t;
        }

        [WebMethod]
        public List<String> selectdb(String Shop)
        {

            prods = new List<String>();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            con.Open();
            DataSet dsProducts = new DataSet();
            SqlDataAdapter daProducts = new SqlDataAdapter("select * from Products where Shop='"+Shop+"'", con); daProducts.Fill(dsProducts, "Products"); 
            foreach (DataRow dr in dsProducts.Tables["Products"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                prods.Add(name);
            }
            con.Close();
            return prods;

        }

        [WebMethod]
        public bool deleteDB(String Product,String Shop)
        {
            bool t = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            con.Open();
            String q = "delete from Products where Name='" + Product + "'and Shop='" + Shop + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
                t = true;
            return t;
        }

        [WebMethod]
        public bool updateDB(String Product, String Shop, int nId, String nName, int nNo, float nPrice, String nShop)
        {
            bool t = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            con.Open();
            String q = "UPDATE Products set Id='"+nId+ "',Name='" + nName + "',Number='" + nNo + "',Price='" + nPrice + "',Shop='" + nShop + "'" +
                "  where Name='" + Product + "'and Shop='" + Shop + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
                t = true;
            return t;
        }

        [WebMethod]
        public List<String> selectAnItem(String Shop,String Name)
        {

            prods = new List<String>();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            con.Open();
            DataSet dsProducts = new DataSet();
            SqlDataAdapter daProducts = new SqlDataAdapter("select * from Products where Name='" + Name + "' and Shop='" + Shop + "'", con); 
            daProducts.Fill(dsProducts, "Products");
            foreach (DataRow dr in dsProducts.Tables["Products"].Rows)
                for(int i=0;i<5;i++)
            {
                String prodInf = dr.ItemArray.GetValue(i).ToString();
                prods.Add(prodInf);
            }
            con.Close();
            return prods;

        }




    }
}
