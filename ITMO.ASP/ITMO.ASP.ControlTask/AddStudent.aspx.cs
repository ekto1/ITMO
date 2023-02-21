using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITMO.ASP2023.FinalTask
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Page.Validate();
                if (!Page.IsValid) { return; }

                try
                {
                    Student student = new Student(firstname.Text, lastname.Text, Int32.Parse(studentScore.SelectedValue));
                    var context = new SampleContext();
                    context.Students.Add(student);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Response.Redirect("Error: " + ex.Message);
                }
                Response.Redirect("Success.aspx");
            }
        }
    }
}