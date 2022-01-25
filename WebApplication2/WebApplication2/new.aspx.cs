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
    public partial class _new : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QPOLNMO;Initial Catalog=PhoneBook;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (name.Text != "" && date.Text != "" && no.Text != "" && desc.Text != "")
            {
                cmd.CommandText = "insert into Customers values(' " + name.Text + " ', ' " + date.Text + " ',' " + no.Text + " ',' " + desc.Text + " ')";
                cmd.ExecuteNonQuery();
                Response.Redirect("Webform2.aspx");
            }
            else
            {
                message.Text = "Please enter customer info.";
            }

            
        }
    }
}