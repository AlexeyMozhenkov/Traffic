using System;
using System.IO;
using System.Linq;
namespace Traffic.WordTemplates
{
    class DeptTemplate: BaseWordTemplate, IWordTemplate
    {
        private const string FileName = "Dept.dotx";
        public DeptTemplate() : base(FileName) { }
        public DeptTemplate(string folder) : base(Path.Combine(folder, FileName)) { }
        public void Fill(long id)
        {
 
            using (var db = new trafficEntities())
            {
                var wordTable = GetTable("DeptTable");
                var sqlTabl = (from item in db.ActTransportation
                               where item.RequestNumber == id
                               select item).ToList();
                int indexWordtable = 0;
                for (var index = 0; index < sqlTabl.Count; index++) { 
                    wordTable.Rows.Add();
                wordTable.Cell(indexWordtable + 2, 1).Range.Text = sqlTabl[index].ActDate.ToString();
                wordTable.Cell(indexWordtable + 2, 2).Range.Text = sqlTabl[index].ActNumber.ToString();
                wordTable.Cell(indexWordtable + 2, 3).Range.Text = sqlTabl[index].CMR.ToString();
                wordTable.Cell(indexWordtable + 2, 4).Range.Text = sqlTabl[index].RequestNumber.ToString();
                indexWordtable++;
                }      
            }
        }

        #region AutoProperties

        public DateTime StartPerioDateTime { get; set; }
        public DateTime EndPerioDateTime { get; set; }


        public string OrderNumber 
        {
            get { return GetVariable("OrderNumber"); }
            set { SetVariable("OrderNumber", value); }
        }
        public string CompanyName
        {
            get { return GetVariable("CompanyName"); }
            set { SetVariable("CompanyName", value); }
        }
        public string PeriodDate
        {
            get { return GetVariable("PeriodDate"); }
            set { SetVariable("PeriodDate", value); }
        }
        public string DeptStartPeriod
        {
            get { return GetVariable("DeptStartPeriod"); }
            set { SetVariable("DeptStartPeriod", value); }
        }
        public string DeptEndPeriod
        {
            get { return GetVariable("DeptEndPeriod"); }
            set { SetVariable("DeptEndPeriod", value); }
        }

        #endregion
    }
}
