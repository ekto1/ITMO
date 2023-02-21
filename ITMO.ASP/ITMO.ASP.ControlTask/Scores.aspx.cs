using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITMO.ASP2023.FinalTask
{
    public partial class Scores : System.Web.UI.Page
    {
        public static string connect = @"data source=(localdb)\MSSQLLocalDB;Integrated Security=True;AttachDBFilename=|DataDirectory|\Students.mdf;";
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connect);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT SUM(Score) From [dbo].[Students]", con);
                int number = (int)cmd.ExecuteScalar();
                Label1.Text = number.ToString();
            }
            catch (Exception f)
            {
                Response.Redirect("Error: " + f.Message);
            }
        }
    }
}