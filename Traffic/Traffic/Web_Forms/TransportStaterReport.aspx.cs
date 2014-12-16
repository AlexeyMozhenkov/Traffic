using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traffic
{
    public partial class TransportStaterReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridDataBind();
                rbtn_AllUsers.Checked = true;
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = false;
                DataGrid.SelectedIndex = -1;
            }

            if (DataGrid.Rows.Count == 0)
            {
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = false;
            }

            //if no rows selected
            if (DataGrid.SelectedIndex == -1)
            {
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = false;
            }

            DetailedInfoForm.CancelClickedEvent += DetailedInfoForm_CancelClickedEvent;
            DetailedInfoForm.SavedDataEvent += DetailedInfoForm_SavedDataEvent;
        }

        protected void GridDataBind()
        {
            List<transportStateReport> List = TransportStateReportLogic.ReadAllTransportStateReports();
            DataGrid.DataSource = List;
            DataGrid.DataBind();

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
            DetailedInfoForm.SetAddMode();
            mv_Main.SetActiveView(view_Detailed);
        }

        protected void btn_Edit_Click(object sender, EventArgs e)
        {
            transportStateReport updateItem = new transportStateReport();
            List<transportStateReport> List = TransportStateReportLogic.ReadAllTransportStateReports();
            for (int i = 0; i < List.Count; i++)
            {
                if (DataGrid.SelectedRow.Cells[1].Text == List[i].reportID.ToString())
                {
                    updateItem = List[i];
                    break;
                }
            }

            if (updateItem != null)
            {
                //Fill data from selected row into detailed view
                DetailedInfoForm.par_0 = updateItem.reportID;
                DetailedInfoForm.par_1 = updateItem.organizationID;
                DetailedInfoForm.par_2 = updateItem.routeID;
                DetailedInfoForm.par_3 = updateItem.transportID;
                DetailedInfoForm.par_4 = updateItem.tableNumber;
                DetailedInfoForm.par_5 = updateItem.status;
                DetailedInfoForm.par_6 = updateItem.notes;
                DetailedInfoForm.par_7 = updateItem.location;
                DetailedInfoForm.SetEditMode(updateItem.reportID);
                mv_Main.SetActiveView(view_Detailed);
            }
        }

        protected void btn_Delete_Click(object sender, EventArgs e)
        {
            transportStateReport deleteItem = new transportStateReport();
            List<transportStateReport> List = TransportStateReportLogic.ReadAllTransportStateReports();
            for (int i = 0; i < List.Count; i++)
            {
                if (DataGrid.SelectedRow.Cells[1].Text == List[i].reportID.ToString())
                {
                    deleteItem = List[i];
                    break;
                }
            }
            if (deleteItem != null)
                TransportStateReportLogic.DeleteByID(deleteItem.reportID);
            GridDataBind();

        }

        protected void DataGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataGrid.Rows.Count != 0)
            {
                btn_Edit.Enabled = true;
                btn_Delete.Enabled = true;
            }
        }

        protected void btn_Show_Click(object sender, EventArgs e)
        {
            List<transportStateReport> List = TransportStateReportLogic.ReadFiltered(txt_Filter.Text.ToString());
            DataGrid.DataSource = List;
            DataGrid.DataBind();

            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            DataGrid.SelectedIndex = -1;
        }


        protected void rbtn_AllUsers_CheckedChanged(object sender, EventArgs e)
        {
            txt_Filter.Text = string.Empty;
            txt_Filter.Enabled = false;
            btn_Show.Enabled = false;
            GridDataBind();
        }


        protected void rbtn_Filtered_CheckedChanged(object sender, EventArgs e)
        {
            txt_Filter.Enabled = true;
            btn_Show.Enabled = true;
        }
    }
}