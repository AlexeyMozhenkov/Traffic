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

    public partial class RequestsControl : System.Web.UI.UserControl
    {
        public event CancelClickedDelegate CancelClickedEvent;
        public event SavedDataDelegate SavedDataEvent;
        protected string CurrentView { get; private set; }

        protected string AlternateView { get; private set; }

        protected string SwitchUrl { get; private set; }

        private List<TextBox> _txtFields;
        public bool IsEdit { get; set; }
        public bool IsVisible { get; set; }

        public int Identity { get; set; }
        public long par_1
        {
            get
            {
                return long.Parse(txt_1.Text);
            }
            set
            {
                txt_1.Text = value.ToString();
            }
        }
        public long par_2
        {
            get
            {
                return long.Parse(txt_2.Text);
            }
            set
            {
                txt_2.Text = value.ToString();
            }
        }
        public long par_3
        {
            get
            {
                return long.Parse(txt_3.Text);
            }
            set
            {
                txt_3.Text = value.ToString();
            }
        }



        public DateTime par_4
        {
            get
            {
                return DateTime.Parse(txt_4.Text);
            }
            set
            {

                txt_4.Text = value.ToString("yyyy-MM-dd");
            }
        }

        public string par_5
        {
            get
            {
                return txt_5.Text;
            }
            set
            {
                txt_5.Text = value;
            }
        }
        public string par_6
        {
            get
            {
                return txt_6.Text;
            }
            set
            {
                txt_6.Text = value;
            }
        }
        public string par_7
        {
            get
            {
                return txt_7.Text;
            }
            set
            {
                txt_7.Text = value;
            }
        }
        public string par_8
        {
            get
            {
                return txt_8.Text;
            }
            set
            {
                txt_8.Text = value;
            }
        }
        public string par_9
        {
            get
            {
                return txt_9.Text;
            }
            set
            {
                txt_9.Text = value;
            }
        }
        public string par_10
        {
            get
            {
                return txt_10.Text;
            }
            set
            {
                txt_10.Text = value;
            }
        }
        public decimal par_11
        {
            get
            {
                return decimal.Parse(txt_11.Text);
            }
            set
            {
                txt_11.Text = value.ToString();
            }
        }
        public string par_12
        {
            get
            {
                return txt_12.Text;
            }
            set
            {
                txt_12.Text = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                IsEdit = false;
                ViewState["EditMode"] = IsEdit;
                //txt_1.DataSource = TransportLogic.ListOfIDs();
                //txt_1.DataBind();
            }
            if (ViewState["EditID"] != null)
                txt_1.Text = ViewState["EditID"].ToString();
            _txtFields = new List<TextBox>(7)
            {
                txt_1,
                txt_2,
                txt_3,
                txt_4,
                txt_5,
                txt_6,
                txt_7
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
        }

        protected void btn_AddEdit_Click(object sender, EventArgs e)
        {
            //Add row

            if (IsEdit == false)
                try
                {
                    txt_1.ToString();
                    RequestsLogic.Add(
                        par_1,
                        par_2,
                        par_3,
                        par_4,
                        par_5,
                        par_6,
                        par_7,
                        par_8,
                        par_9,
                        par_10,
                        par_11,
                        par_12
                        );
                }
                catch (ArgumentNullException)
                {
                    Response.Write("Couldn't insert empty row into database");
                }
            else
                try
                {
                    RequestsLogic.Edit(
                        par_1,
                        par_2,
                        par_3,
                        par_4,
                        par_5,
                        par_6,
                        par_7,
                        par_8,
                        par_9,
                        par_10,
                        par_11,
                        par_12
                        );
                }
                catch (ArgumentNullException)
                {
                    Response.Write("Couldn't edit this object");
                }
            if (SavedDataEvent != null)
            {
                SavedDataEvent();
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

        public void SetEditMode(long identity)
        {
            IsEdit = true;
            ViewState["EditMode"] = IsEdit;
            ViewState["EditID"] = identity;
            txt_1.ReadOnly = IsEdit;
            btn_AddEdit.Text = "Edit";
            //necessary if style is changed:    //txt_01.Visible = false;
            //txt_1.Visible = true;
        }
        public void SetAddMode()
        {
            IsEdit = false;
            ViewState["EditMode"] = IsEdit;
            //txt_1.Visible = false;
            txt_1.Visible = true;
            txt_1.ReadOnly = false;
            btn_AddEdit.Text = "ADD";
            ClearControlFields();
        }
    }

}