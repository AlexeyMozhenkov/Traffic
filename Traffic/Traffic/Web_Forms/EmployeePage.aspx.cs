using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traffic
{
    public partial class EmployeePage : System.Web.UI.Page
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
            List<Employee> List = EmployeeLogic.ReadAll();
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

            Employee updateRow = new Employee();

            List<Employee> List = EmployeeLogic.ReadAll();
            for (int i = 0; i < List.Count; i++)
            {
                if (DataGrid.SelectedRow.Cells[3].Text == List[i].tableNumber.ToString())
                {
                    updateRow = List[i];
                    break;
                }
            }

            if (updateRow != null)
            {
                //Fill data from selected row into detailed view
                DetailedInfoForm.par_1 = updateRow.addressID;
                DetailedInfoForm.par_2 = updateRow.organizationID;
                DetailedInfoForm.par_3 = updateRow.tableNumber;
                DetailedInfoForm.par_4 = updateRow.FirstName;
                DetailedInfoForm.par_5 = updateRow.LastName;
                DetailedInfoForm.par_6 = updateRow.ParentName;
                DetailedInfoForm.par_7 = updateRow.BirthDay;
                DetailedInfoForm.par_8 = updateRow.IDnumber;
                DetailedInfoForm.par_9 = updateRow.PassportSerie;
                DetailedInfoForm.par_10 = updateRow.PassportNumber;
                DetailedInfoForm.par_11 = (DateTime) updateRow.DatePassportUntil;
                DetailedInfoForm.par_12 = (DateTime) updateRow.DatePassportFrom;
                DetailedInfoForm.par_13 = updateRow.position;
                DetailedInfoForm.SetEditMode(updateRow.addressID);
                mv_Main.SetActiveView(view_Detailed);
            }
        }


        protected void btn_Delete_Click(object sender, EventArgs e)
        {
            Employee deleteRow = new Employee();

            List<Employee> List = EmployeeLogic.ReadAll();
            for (int i = 0; i < List.Count; i++)
            {
                if (DataGrid.SelectedRow.Cells[1].Text == List[i].addressID.ToString())
                {
                    deleteRow = List[i];
                    break;
                }
            }
            if (deleteRow != null)
                EmployeeLogic.DeleteByID(deleteRow.addressID);
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
            List<Employee> List = EmployeeLogic.GetFilteredUsersInfo(txt_Filter.Text.ToString());
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