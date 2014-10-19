using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traffic
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Enter_Click(object sender, EventArgs e)
        {
            if (DropDownList1.Text == "Директор") Response.Redirect("Web_Forms/BossPage.aspx");
            else if (DropDownList1.Text == "Механик") Response.Redirect("Web_Forms/MechanicPage.aspx");
            else if (DropDownList1.Text == "Логист") Response.Redirect("Web_Forms/LogistPage.aspx");
            else if (DropDownList1.Text == "Водитель") Response.Redirect("Web_Forms/DriverPage.aspx");

        }
    }
}