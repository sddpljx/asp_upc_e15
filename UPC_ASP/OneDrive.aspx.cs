using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationWeb1
{
    public partial class OneDrive : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string OneDrive = "https://supceducn0-my.sharepoint.com/personal/1506020612_s_upc_edu_cn/_layouts/15/guestaccess.aspx?folderid=088bc4728f8bd4d0c8f907ec79c509eb6&authkey=AYwhxNs2V9PFj_tBCY9ZwGQ";
            Response.Redirect(OneDrive, true);
        }
    }
}