using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWeb1
{
    public partial class MSForms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string forms1 = "https://forms.office.com/Pages/ResponsePage.aspx?id=-r_KdaUmKkCHaK-sk8OwBmhsc1imX4lKh491EnWbCtJUOUU0UURKUjlDMThaMk9SVTM4V09XN0EwTi4u";
            Response.Redirect(forms1, true );
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string forms1 = "https://forms.office.com/Pages/ResponsePage.aspx?id=-r_KdaUmKkCHaK-sk8OwBmhsc1imX4lKh491EnWbCtJUNEdZNVNST1VKSDlZMVpRUDlRV1NGVFBaUi4u";
            Response.Redirect(forms1, true);
        }
    }
}