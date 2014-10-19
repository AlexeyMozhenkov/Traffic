using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.FriendlyUrls.Resolvers;

namespace Traffic
{

    public partial class MaintenanceControl : System.Web.UI.UserControl
    {
        public event CancelClickedDelegate CancelClickedEvent;
        public event SavedDataDelegate SavedDataEvent;
        private List<TextBox> _txtFields;
        public bool IsEdit { get; set; }
        protected string CurrentView { get; private set; }

        protected string AlternateView { get; private set; }

        protected string SwitchUrl { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsEdit = false;
                ViewState["EditMode"] = IsEdit;
            }
            _txtFields = new List<TextBox>(5)
            {
                txt_1,
                txt_2,
                txt_3,
                txt_4,
                txt_5
                
            };

            IsEdit = (bool)ViewState["EditMode"];

            // Determine current view
            var isMobile = WebFormsFriendlyUrlResolver.IsMobileView(new HttpContextWrapper(Context));
            CurrentView = isMobile ? "Mobile" : "Desktop";

            // Determine alternate view
            AlternateView = isMobile ? "Desktop" : "Mobile";

            // Create switch URL from the route, e.g. ~/__FriendlyUrls_SwitchView/Mobile?ReturnUrl=/Page
            var switchViewRouteName = "AspNet.FriendlyUrls.SwitchView";
            var switchViewRoute = RouteTable.Routes[switchViewRouteName];
            if (switchViewRoute == null)
            {
                // Friendly URLs is not enabled or the name of the switch view route is out of sync
                this.Visible = false;
                return;
            }
            var url = GetRouteUrl(switchViewRouteName, new { view = AlternateView, __FriendlyUrls_SwitchViews = true });
            url += "?ReturnUrl=" + HttpUtility.UrlEncode(Request.RawUrl);
            SwitchUrl = url;
        }

        protected void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (CancelClickedEvent != null)
            {
                this.CancelClickedEvent();
            }
            ClearControlFields();
        }

        private void ClearControlFields()
        {
            foreach (TextBox txtField in _txtFields)
            {
                txtField.Text = string.Empty;
            }
        }

    }
}