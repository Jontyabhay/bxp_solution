using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Question5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             
            if ((int)Session["Count"] < 2)
            {
                Session["Count"]=(int)Session["Count"]+1;
                Response.Redirect("Design1.aspx");
            }
            else if ((int)Session["Count"] == 2)
            {
                Session["Count"] = (int)Session["Count"] + 1;
                Response.Redirect("Design2.aspx");
            }
            else
            {
                Session["Count"] = 0;
                Response.Redirect("Design3.aspx");
            }
        }
    }
}