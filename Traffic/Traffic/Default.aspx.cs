using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using Traffic.WordTemplates;
using System.Security.Permissions;
namespace Traffic
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                PrincipalPermission pp = new PrincipalPermission("admin", null);
                pp.Demand();
                Enter.Visible = true;
                Row.Visible = true;
                // Если управление достигло этой точки, требование удовлетворено.
                // Текущий пользователь является администратором
            }
            catch (Exception SecurityException)
            {
                //Response.Write(SecurityException);
                // Требование не выполнено. Текущий пользователь не является администратором
            }
        }

        protected void btn_Enter_Click(object sender, EventArgs e)
        {
            if (DropDownList1.Text == "Директор") Response.Redirect("Web_Forms/BossPage.aspx");
            else if (DropDownList1.Text == "Механик") Response.Redirect("Web_Forms/MechanicPage.aspx");
            else if (DropDownList1.Text == "Логист") Response.Redirect("Web_Forms/LogistPage.aspx");
            else if (DropDownList1.Text == "Водитель") Response.Redirect("Web_Forms/DriverPage.aspx");

        }

        protected void btn_Enter0_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, "App_Data");//получить папку с файлами
            var invoice = new DeptTemplate(path);//создать класс с шаблоном
            //invoice.Fill(Int64.Parse(DataGrid.SelectedRow.Cells[1].Text));//заполнить
            invoice.Fill(1);//заполнить
            var tmpFilePath = Path.GetTempFileName();//создать и получить имя временного файла
            invoice.DocWord.SaveAs(tmpFilePath);//сохранить наш заполненный документ во временный файл
            invoice.Dispose();//закрыть шаблон
            var tmpFileBytes = File.ReadAllBytes(tmpFilePath);//взять байты из файла
            if (File.Exists(tmpFilePath))//если есть временный файл
                File.Delete(tmpFilePath);//удалить его
            Response.Clear();//очистить ответ
            Response.ContentType = "application/msword";//выбрать тип содержимого
            Response.AddHeader("Content-Disposition", "attachment; filename=DeptTemplate.docx");//присоеденненые данные и имя файла
            Response.BinaryWrite(tmpFileBytes);//записать байты в ответ
            Response.Flush();//очистить буфер ответа
            Response.Close();//закрыть поток
            Response.End();//закончить ответ
        }
    }
}