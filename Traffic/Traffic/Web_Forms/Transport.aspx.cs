using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using TrafficBusinessLogic;
namespace Traffic
{
    public partial class Transport1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridDataBind();
                rbtn_AllUsers.Checked = true;
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = false;
                TransportDataGrid.SelectedIndex = -1;
            }

            if (TransportDataGrid.Rows.Count == 0)
            {
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = false;
            }

            //if no rows selected
            if (TransportDataGrid.SelectedIndex == -1)
            {
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = false;
            }

            DetailedInfoForm.CancelClickedEvent += DetailedInfoForm_CancelClickedEvent;
            DetailedInfoForm.SavedDataEvent += DetailedInfoForm_SavedDataEvent;
        }

        protected void GridDataBind()
        {
            List<Transport> TrList = TransportLogic.ReadAllTransports();
            TransportDataGrid.DataSource = TrList;
            TransportDataGrid.DataBind();
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
            //DetailedInfoForm.SetEditMode();

            Transport updateTransport = new Transport();

            List<Transport> TrList = TransportLogic.ReadAllTransports();
            for (int i = 0; i < TrList.Count; i++)
            {
                if (TransportDataGrid.SelectedRow.Cells[1].Text == TrList[i].transportID.ToString())
                {
                    updateTransport = TrList[i];
                    break;
                }
            }

            if (updateTransport != null)
            {
                //Fill data from selected row into detailed view
                DetailedInfoForm.par_1 = updateTransport.transportID;
                DetailedInfoForm.par_2 = updateTransport.model;
                DetailedInfoForm.par_3 = updateTransport.registrationNumber;
                DetailedInfoForm.par_4 = updateTransport.VIN;
                DetailedInfoForm.par_5 = updateTransport.transportType;
                DetailedInfoForm.par_6 = updateTransport.transportCategory;
                DetailedInfoForm.par_7 = updateTransport.transportMakingYear;
                DetailedInfoForm.par_8 = updateTransport.ecologyClass;
                DetailedInfoForm.par_9 = updateTransport.maxWeight;
                DetailedInfoForm.par_10 = updateTransport.weight;
                DetailedInfoForm.par_11 = updateTransport.engineType;
                DetailedInfoForm.par_12 = updateTransport.engineVolume;
                DetailedInfoForm.SetEditMode(updateTransport.transportID);
                mv_Main.SetActiveView(view_Detailed);
            }
        }

        protected void TransportDataGrid_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (TransportDataGrid.Rows.Count != 0)
            {
                btn_Edit.Enabled = true;
                btn_Delete.Enabled = true;
            }
        }

        protected void btn_Delete_Click(object sender, EventArgs e)
        {
            Transport deleteTransport = new Transport();

            List<Transport> TrList = TransportLogic.ReadAllTransports();
            for (int i = 0; i < TrList.Count; i++)
            {
                if (TransportDataGrid.SelectedRow.Cells[1].Text == TrList[i].transportID.ToString())
                {
                    deleteTransport = TrList[i];
                    break;
                }
            }
            if (deleteTransport!=null)
                TransportLogic.DeleteByID(deleteTransport.transportID);
            GridDataBind();
            
        }

        
    }
}