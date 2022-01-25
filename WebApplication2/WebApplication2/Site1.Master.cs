using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QPOLNMO;Initial Catalog=PhoneBook;Integrated Security=True");
        string id = "";
        string islem = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            id = Request.QueryString["id"];
            islem = Request.QueryString["islem"];

            string select = "select * from Customers ";
            SqlCommand command = new SqlCommand(select, con);
            SqlDataReader srd = command.ExecuteReader();

            

            DataList1.DataSource = srd;
            DataList1.DataBind();
            srd.Close();

            if ( islem == "sil")
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Customers where Id = '" + id + " '";
                cmd.ExecuteNonQuery();

                Response.Redirect("WebForm2.aspx");
            }
        }

        protected void NewButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("new.aspx");
        }
        protected void EditButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("edit.aspx");
        }
      
    }
}