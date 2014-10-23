using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traffic
{
    public partial class InternationalCards : System.Web.UI.Page
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
            btn_Edit.Enabled = true;
            btn_Delete.Enabled = true;
            DetailedInfoForm.CancelClickedEvent += DetailedInfoForm_CancelClickedEvent;
            DetailedInfoForm.SavedDataEvent += DetailedInfoForm_SavedDataEvent;
        }

        protected void GridDataBind()
        {
            //InternationalCardClass card = new InternationalCardClass(1, 1, "1", DateTime.Today, DateTime.Today, 1);
            //List<InternationalCardClass> MyList = new List<InternationalCardClass>(); 
            //MyList.Add(card);
            List<InternationalCardClass> MyList = InternationalCardClass.ReadAllCards();
            DataGrid.DataSource = MyList;
            //DataGrid.DataBind();
            
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
            InternationalCardClass updateItem = new InternationalCardClass();
            List<InternationalCardClass> List =InternationalCardClass.ReadAllCards();
            for (int i = 0; i < List.Count; i++)
            {
                //if (DataGrid.SelectedRow.Cells[1].Text == MyList[i].RegistrationID.ToString())
                if (List.Count.ToString() == List[i].RegistrationID.ToString())
                {
                    updateItem = List[i];
                    break;
                }
            }

            if (updateItem != null)
            {
                //Fill data from selected row into detailed view
                DetailedInfoForm.par_1 = updateItem.RegistrationID;
                DetailedInfoForm.par_2 = updateItem.ApprovalCert;
                DetailedInfoForm.par_3 = updateItem.DateFrom;
                DetailedInfoForm.par_4 = updateItem.DateUntil;
                DetailedInfoForm.par_5 = updateItem.TransportID;
                DetailedInfoForm.par_6 = updateItem.OrganizationID;
                DetailedInfoForm.SetEditMode(updateItem.RegistrationID);
                mv_Main.SetActiveView(view_Detailed);
            }
            //else 
            //{
            //    DetailedInfoForm.par_1 = 0;
            //    mv_Main.SetActiveView(view_Detailed);
            //}
        }

        protected void btn_Delete_Click(object sender, EventArgs e)
        {
            InternationalCardClass deleteItem = new InternationalCardClass();
            List<InternationalCardClass> List = InternationalCardClass.ReadAllCards();
            for (int i = 0; i < List.Count; i++)
            {
                //if (DataGrid.SelectedRow.Cells[1].Text == List[i].RegistrationID.ToString())
                if (List.Count.ToString() == List[i].RegistrationID.ToString())
                {
                    deleteItem = List[i];
                    break;
                }
            }
            if (deleteItem != null)
                InternationalCardClass.DeleteByTransportID(deleteItem.RegistrationID);
            GridDataBind();

        }
    }
}