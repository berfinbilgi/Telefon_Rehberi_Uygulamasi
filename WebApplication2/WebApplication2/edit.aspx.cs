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
    public partial class edit : System.Web.UI.Page
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

            if (islem == "sil")
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                if (name.Text != "")
                    cmd.CommandText = " update Customers set CustomerName = ' " + name.Text + "' where Id = '" + id + "' ";
                if (date.Text != "")
                    cmd.CommandText = " update Customers set CustomerBirthDate = ' " + date.Text + " ' where Id = '" + id + "' ";
                if (no.Text != "")
                    cmd.CommandText = " update Customers set CustomerPhoneNumber = ' " + no.Text + "' where Id = '" + id + "' ";
                if (desc.Text != "")
                    cmd.CommandText = " update Customers set CustomerDescription = ' " + desc.Text + "' where Id = '" + id + "' ";
                cmd.ExecuteNonQuery();

                name.Text = "";
                date.Text = "";
                no.Text = "";
                desc.Text = "";


                Response.Redirect("WebForm2.aspx");
            }
        }

       

    }  
}