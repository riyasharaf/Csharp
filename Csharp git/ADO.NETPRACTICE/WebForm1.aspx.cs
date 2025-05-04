using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO.NETPRACTICE
{
    public partial class WebForm1 : System.Web.UI.Page
    {
         

        protected void Page_Load(object sender, EventArgs e)
        {
            //string cse = ConfigurationManager.ConnectionStrings["ADONETConnString"].ConnectionString;
            //SqlConnection con = new SqlConnection(cse);
            //SqlCommand cmd = new SqlCommand("select * from Contacts", con);
            //con.Open();
            //SqlDataReader r1 = cmd.ExecuteReader();
            //GridView1.DataSource = r1;
            //GridView1.DataBind();
            //con.Close();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string cse = ConfigurationManager.ConnectionStrings["ADONETConnString"].ConnectionString;
            using(SqlConnection n1 = new SqlConnection(cse))
            {
                SqlCommand q = new SqlCommand("Insert into Contacts Values(@ID , @Name , @PhoneNum)",n1);
                q.Parameters.AddWithValue("@ID", int.Parse(TextBox1.Text));
                q.Parameters.AddWithValue("@Name", TextBox2.Text);
                q.Parameters.AddWithValue("@PhoneNum", TextBox3.Text);
                n1.Open();
                int ra = (int)q.ExecuteNonQuery();
                Response.Write("Rows Affected = " + ra.ToString());
            }
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string cse = ConfigurationManager.ConnectionStrings["ADONETConnString"].ConnectionString;
            using (SqlConnection n1 = new SqlConnection(cse))
            {
                SqlCommand q = new SqlCommand("Update Contacts set Name = @i1 where Name = @i2 ", n1);
                q.Parameters.AddWithValue("@i1", TextBox4.Text);
                q.Parameters.AddWithValue("@i2", TextBox5.Text);
               
                n1.Open();
                int ra = (int)q.ExecuteNonQuery();
                Response.Write("Rows Affected = " + ra.ToString());
            }


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string cse = ConfigurationManager.ConnectionStrings["ADONETConnString"].ConnectionString;
            using (SqlConnection n1 = new SqlConnection(cse))
            {
                SqlCommand q = new SqlCommand("Select Count(ID) from Contacts", n1);
               

                n1.Open();
                int ra = (int)q.ExecuteScalar();
                Response.Write("Rows Affected = " + ra.ToString());
                TextBox6.Text = ra.ToString();
            }


        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}