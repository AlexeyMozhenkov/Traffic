using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traffic
{
    public partial class Maintenance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridDataBind();
                rbtn_AllUsers.Checked = true;
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = false;
                _DataGrid.SelectedIndex = -1;
            }

            if (_DataGrid.Rows.Count == 0)
            {
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = false;
            }

            //if no rows selected
            if (_DataGrid.SelectedIndex == -1)
            {
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = false;
            }

            DetailedInfoForm.CancelClickedEvent += DetailedInfoForm_CancelClickedEvent;
            DetailedInfoForm.SavedDataEvent += DetailedInfoForm_SavedDataEvent;
        }

        void DetailedInfoForm_CancelClickedEvent()
        {
            mv_Main.SetActiveView(view_DataGrid);
        }

        void DetailedInfoForm_SavedDataEvent()
        {
            GridDataBind();
            mv_Main.SetActiveView(view_DataGrid);
        }
        protected void btn_Add_Click(object sender, EventArgs e)
        {

            mv_Main.SetActiveView(view_Detailed);
        }

        protected void GridDataBind()
        {
            List<MaintenanceClass> List = MaintenanceClass.ReadAllMaintenanceClasses();
            _DataGrid.DataSource = List;
            //_DataGrid.DataBind();
        }
    }

}