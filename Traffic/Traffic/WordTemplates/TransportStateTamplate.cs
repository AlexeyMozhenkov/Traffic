using System;
using System.IO;
using System.Linq;
namespace Traffic.WordTemplates
{
    public class TransportStateTamplate : BaseWordTemplate, IWordTemplate
    {
        private const string FileName = "TransportState.dotx";
        public TransportStateTamplate() : base(FileName) { }
        public TransportStateTamplate(string folder) : base(Path.Combine(folder, FileName)) { }
        public void Fill(long id)
        {
            
        }

        public void FillAll()
        {
            using (var db = new trafficEntities())
            {

                Date = DateTime.Today.Date.ToString("dd.MM.yyyy");
                var wordTable = GetTable("Table1");
                var sqlTabl = (from item in db.transportStateReport
                               where item.routeID >0
                               select item).ToList();
                int indexWordtable = 0;
                for (var index = 0; index < sqlTabl.Count; index++)
                {
                    wordTable.Rows.Add();
                    var transportID = sqlTabl[index].transportID;
                    var infoTransport = (from item in db.Transport
                                         where item.transportID == transportID
                                         select item).SingleOrDefault();
                    if (infoTransport == null) return;
                    wordTable.Cell(indexWordtable + 3, 2).Range.Text = string.Format("{0} {1} ", infoTransport.model, infoTransport.registrationNumber);
                    wordTable.Cell(indexWordtable + 3, 3).Range.Text = sqlTabl[index].location.ToString() +"\n"+ sqlTabl[index].status.ToString();
                    wordTable.Cell(indexWordtable + 3, 4).Range.Text = sqlTabl[index].PointOfShipment.ToString() + " - " + sqlTabl[index].PointOfDelivery.ToString();
                    wordTable.Cell(indexWordtable + 3, 5).Range.Text = sqlTabl[index].Shipper.ToString();
                    wordTable.Cell(indexWordtable + 3, 6).Range.Text = sqlTabl[index].DeliveryPeriod.ToString("dd.MM.yyyy");
                    wordTable.Cell(indexWordtable + 3, 7).Range.Text = sqlTabl[index].notes.ToString();
                    indexWordtable++;
                    wordTable.Cell(indexWordtable + 3, 1).Range.Text = indexWordtable.ToString();
                }
            }
        }

        #region AutoProperties

        
        public string Date
        {
            get { return (GetVariable("Date")); }
            set { SetVariable("Date", value); }
        }
        #endregion
    }
}
