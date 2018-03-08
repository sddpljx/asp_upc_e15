using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWeb1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string OneNote = "https://onenote.com/webapp/pages?token=a-x0pt_OmQkxY1XQy05aIdiThH8HXw9ZInONVs24ygEIr__L_commvD9mdQuUO6wpqHlP35Yo4UqSOKn9-9_TLTE6MHWWAFU0&id=636421629727278129";
            Response.Redirect(OneNote, true);
        }
    }
}