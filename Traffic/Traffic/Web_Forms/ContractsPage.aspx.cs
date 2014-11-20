using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traffic
{
    public partial class ContractsPage : System.Web.UI.Page
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
            List<Contracts> List = ContractsLogic.ReadAll();
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
            //DetailedInfoForm.SetEditMode();

            Contracts updateRow = new Contracts();

            List<Contracts> List = ContractsLogic.ReadAll();
            for (int i = 0; i < List.Count; i++)
            {
                if (DataGrid.SelectedRow.Cells[1].Text == List[i].contractID.ToString())
                {
                    updateRow = List[i];
                    break;
                }
            }

            if (updateRow != null)
            {
                //Fill data from selected row into detailed view
                DetailedInfoForm.par_1 = updateRow.contractID;
                DetailedInfoForm.par_2 = updateRow.organizationID;
                DetailedInfoForm.par_3 = updateRow.contractNumber;
                DetailedInfoForm.par_4 = (DateTime)updateRow.contractDate;
                DetailedInfoForm.par_5 = updateRow.contractType;

                DetailedInfoForm.SetEditMode(updateRow.contractID);
                mv_Main.SetActiveView(view_Detailed);
            }
        }

        protected void TransportDataGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataGrid.Rows.Count != 0)
            {
                btn_Edit.Enabled = true;
                btn_Delete.Enabled = true;
            }
        }

        protected void btn_Delete_Click(object sender, EventArgs e)
        {
            Contracts deleteRow = new Contracts();

            List<Contracts> List = ContractsLogic.ReadAll();
            for (int i = 0; i < List.Count; i++)
            {
                if (DataGrid.SelectedRow.Cells[1].Text == List[i].contractID.ToString())
                {
                    deleteRow = List[i];
                    break;
                }
            }
            if (deleteRow != null)
                ContractsLogic.DeleteByID(deleteRow.contractID);
            GridDataBind();

        }


    }
}