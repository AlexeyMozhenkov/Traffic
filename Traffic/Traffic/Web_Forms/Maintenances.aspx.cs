using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traffic
{
    public partial class Maintenances : System.Web.UI.Page
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
            DataGrid.DataSource = List;
            DataGrid.DataBind();
        }


        protected void btn_Edit_Click(object sender, EventArgs e)
        {
            MaintenanceClass updateItem = new MaintenanceClass();
            List<MaintenanceClass> List = MaintenanceClass.ReadAllMaintenanceClasses();
            for (int i = 0; i < List.Count; i++)
            {
                if (DataGrid.SelectedRow.Cells[1].Text == List[i].maintenanceID.ToString())
                {
                    updateItem = List[i];
                    break;
                }
            }

            if (updateItem != null)
            {
                //Fill data from selected row into detailed view
                DetailedInfoForm.par_1 = updateItem.maintenanceID;
                DetailedInfoForm.par_2 = updateItem.transportID;
                DetailedInfoForm.par_3 = updateItem.dateFrom;
                DetailedInfoForm.par_4 = updateItem.dateUntil;
                DetailedInfoForm.par_5 = updateItem.typeCostID;
                DetailedInfoForm.par_6 = updateItem.cost;
                DetailedInfoForm.SetEditMode(updateItem.maintenanceID);
                mv_Main.SetActiveView(view_Detailed);
            }
        }

        protected void btn_Delete_Click(object sender, EventArgs e)
        {
            MaintenanceClass deleteItem = new MaintenanceClass();
            List<MaintenanceClass> List = MaintenanceClass.ReadAllMaintenanceClasses();
            for (int i = 0; i < List.Count; i++)
            {
                if (DataGrid.SelectedRow.Cells[1].Text == List[i].maintenanceID.ToString())
                {
                    deleteItem = List[i];
                    break;
                }
            }
            if (deleteItem != null)
                MaintenanceClass.DeleteByID(deleteItem.maintenanceID);
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

    }

}