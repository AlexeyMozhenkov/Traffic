using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traffic
{
    public partial class TechnicalInspection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Add_Click(object sender, EventArgs e)
        {

            mv_Main.SetActiveView(view_Detailed);
        }
    }
}