﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using Traffic.WordTemplates;
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
                btn_GetFile.Enabled = false;
                DataGrid.SelectedIndex = -1;
            }

            if (DataGrid.Rows.Count == 0)
            {
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = false;
                btn_GetFile.Enabled = false;
            }

            //if no rows selected
            if (DataGrid.SelectedIndex == -1)
            {
                btn_Edit.Enabled = false;
                btn_Delete.Enabled = false;
                btn_GetFile.Enabled = false;
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
                DetailedInfoForm.par_2 = updateRow.PerformerID;
                DetailedInfoForm.par_3 = updateRow.CustomerID;
                DetailedInfoForm.par_4 = updateRow.ContractNumber;
                DetailedInfoForm.par_5 = (DateTime)updateRow.DateFrom;
                DetailedInfoForm.par_6 = (DateTime)updateRow.DateUntil;
                DetailedInfoForm.par_7 = updateRow.Place;
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
                btn_GetFile.Enabled = true;
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

        protected void btn_Show_Click(object sender, EventArgs e)
        {
            List<Contracts> List = ContractsLogic.ReadFiltered(txt_Filter.Text.ToString());
            DataGrid.DataSource = List;
            DataGrid.DataBind();

            btn_Edit.Enabled = false;
            btn_Delete.Enabled = false;
            btn_GetFile.Enabled = false;
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

        protected void btn_GetFile_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, "App_Data");//получить папку с файлами
            var invoice = new СontractTamplate(path);//создать класс с шаблоном
            invoice.Fill(Int64.Parse(DataGrid.SelectedRow.Cells[1].Text));//заполнить
            //invoice.Fill(1);//заполнить
            var tmpFilePath = Path.GetTempFileName();//создать и получить имя временного файла
            invoice.DocWord.SaveAs(tmpFilePath);//сохранить наш заполненный документ во временный файл
            invoice.Dispose();//закрыть шаблон
            var tmpFileBytes = File.ReadAllBytes(tmpFilePath);//взять байты из файла
            if (File.Exists(tmpFilePath))//если есть временный файл
                File.Delete(tmpFilePath);//удалить его
            Response.Clear();//очистить ответ
            Response.ContentType = "application/msword";//выбрать тип содержимого
            Response.AddHeader("Content-Disposition", "attachment; filename=Договор.docx");//присоеденненые данные и имя файла
            Response.BinaryWrite(tmpFileBytes);//записать байты в ответ
            Response.Flush();//очистить буфер ответа
            Response.Close();//закрыть поток
            Response.End();//закончить ответ
        }


    }
}