using System;
using System.IO;
using System.Linq;
namespace Traffic.WordTemplates
{
    public class WaybillsTamplate : BaseWordTemplate, IWordTemplate
    {
        private const string FileName = "Waybills.dotx";
        public WaybillsTamplate() : base(FileName) { }
        public WaybillsTamplate(string folder) : base(Path.Combine(folder, FileName)) { }
        public void Fill(long id)
        {
            using (var db = new trafficEntities())
            {
                
                var infoWaybill = (from item in db.Waybills
                    where item.waybillID == id
                    select item).SingleOrDefault();
                if (infoWaybill == null) return;

                waybillNumber = (int)infoWaybill.waybillNumber;
                creationDate = (DateTime)infoWaybill.creationDate;
                driversTableNumber = infoWaybill.driversTableNumber;
                speedometerOnDeparture = (float)infoWaybill.speedometerOnDeparture;
                speedometerOnReturn = (float)infoWaybill.speedometerOnReturn;
                departureDateShedule = (DateTime)infoWaybill.departureDateShedule;
                departureTimeShedule = (TimeSpan)infoWaybill.departureTimeShedule;
                departureDateFact = (DateTime)infoWaybill.departureDateFact;
                departureTimeFact = (TimeSpan)infoWaybill.departureTimeFact;
                returnDateShedule = (DateTime)infoWaybill.returnDateShedule;
                returnTimeShedule = (TimeSpan)infoWaybill.returnTimeShedule;
                returnDateFact = (DateTime)infoWaybill.returnDateFact;
                returnTimeFact = (TimeSpan)infoWaybill.returnTimeFact;
                zeroMileage = (float)infoWaybill.zeroMileage;
                engineTime = (float)infoWaybill.engineTime;
                soecialEquipmentTime = (float)infoWaybill.soecialEquipmentTime;
                FLMrestOnDeparture = (float)infoWaybill.FLMrestOnDeparture;
                FLMrestOnReturn = (float)infoWaybill.FLMrestOnReturn;

                var infoСar = (from item in db.Transport
                               where item.transportID == infoWaybill.carID
                                   select item).SingleOrDefault();
                if (infoСar == null) return;
                CarModel = infoСar.model;
                CarRN = infoСar.registrationNumber;

                var infoTrailer = (from item in db.Transport
                               where item.transportID == infoWaybill.trailerID
                               select item).SingleOrDefault();
                if (infoTrailer == null) return;
                TrailerModel = infoTrailer.model;
                TrailerRN = infoTrailer.registrationNumber;

                var infoDriver = (from item in db.Employee
                                   where item.tableNumber == infoWaybill.driversTableNumber
                                   select item).SingleOrDefault();
                if (infoDriver == null) return;
                FIO = string.Format("{0} {1} {2}", infoDriver.LastName, infoDriver.FirstName, infoDriver.ParentName);

                var wordTable = GetTable("Table1");
                var sqlTabl = (from item in db.transportStateReport
                               where item.routeID == id
                               select item).ToList();
                int indexWordtable = 0;
                for (var index = 0; index < sqlTabl.Count; index++)
                {
                    wordTable.Rows.Add();
                    wordTable.Cell(indexWordtable + 4, 1).Range.Text = sqlTabl[index].Customer.ToString();
                    wordTable.Cell(indexWordtable + 4, 2).Range.Text = sqlTabl[index].DepartureDate.ToString();
                    wordTable.Cell(indexWordtable + 4, 3).Range.Text = sqlTabl[index].DeliveryPeriod.ToString();
                    wordTable.Cell(indexWordtable + 4, 4).Range.Text = sqlTabl[index].PointOfShipment.ToString();
                    wordTable.Cell(indexWordtable + 4, 5).Range.Text = sqlTabl[index].PointOfDelivery.ToString();
                    wordTable.Cell(indexWordtable + 4, 7).Range.Text = sqlTabl[index].Shipment.ToString();
                    indexWordtable++;
                }      
            }
        }

        #region AutoProperties

        public int waybillNumber
        {
            get { return int.Parse(GetVariable("waybillNumber")); }
            set { SetVariable("waybillNumber", value.ToString()); }
        }
        public DateTime creationDate
        {
            get { return DateTime.Parse(GetVariable("creationDate")); }
            set { SetVariable("creationDate", value.ToString("dd.MM.yyyy")); }
        }
        public string driversTableNumber
        {
            get { return (GetVariable("driversTableNumber")); }
            set { SetVariable("driversTableNumber", value); }
        }
        public float speedometerOnDeparture
        {
            get { return float.Parse(GetVariable("speedometerOnDeparture")); }
            set { SetVariable("speedometerOnDeparture", value.ToString()); }
        }
        public float speedometerOnReturn
        {
            get { return float.Parse(GetVariable("speedometerOnReturn")); }
            set { SetVariable("speedometerOnReturn", value.ToString()); }
        }
        public DateTime departureDateShedule
        {
            get { return DateTime.Parse(GetVariable("departureDateShedule")); }
            set { SetVariable("departureDateShedule", value.ToString("dd.MM.yyyy")); }
        }
        public TimeSpan departureTimeShedule
        {
            get { return TimeSpan.Parse(GetVariable("departureTimeShedule")); }
            set { SetVariable("departureTimeShedule", value.ToString("t")); }
        }
        public DateTime departureDateFact
        {
            get { return DateTime.Parse(GetVariable("departureDateFact")); }
            set { SetVariable("departureDateFact", value.ToString("dd.MM.yyyy")); }
        }
        public TimeSpan departureTimeFact
        {
            get { return TimeSpan.Parse(GetVariable("departureTimeFact")); }
            set { SetVariable("departureTimeFact", value.ToString("t")); }
        }
        public DateTime returnDateShedule
        {
            get { return DateTime.Parse(GetVariable("returnDateShedule")); }
            set { SetVariable("returnDateShedule", value.ToString("dd.MM.yyyy")); }
        }
        public TimeSpan returnTimeShedule
        {
            get { return TimeSpan.Parse(GetVariable("returnTimeShedule")); }
            set { SetVariable("returnTimeShedule", value.ToString("t")); }
        }
        public DateTime returnDateFact
        {
            get { return DateTime.Parse(GetVariable("returnDateFact")); }
            set { SetVariable("returnDateFact", value.ToString("dd.MM.yyyy")); }
        }
        public TimeSpan returnTimeFact
        {
            get { return TimeSpan.Parse(GetVariable("returnTimeFact")); }
            set { SetVariable("returnTimeFact", value.ToString("t")); }
        }
        public float zeroMileage
        {
            get { return float.Parse(GetVariable("zeroMileage")); }
            set { SetVariable("zeroMileage", value.ToString()); }
        }
        public float engineTime
        {
            get { return float.Parse(GetVariable("engineTime")); }
            set { SetVariable("engineTime", value.ToString()); }
        }
        public float soecialEquipmentTime
        {
            get { return float.Parse(GetVariable("soecialEquipmentTime")); }
            set { SetVariable("soecialEquipmentTime", value.ToString()); }
        }
        public float FLMrestOnDeparture
        {
            get { return float.Parse(GetVariable("FLMrestOnDeparture")); }
            set { SetVariable("FLMrestOnDeparture", value.ToString()); }
        }
        public float FLMrestOnReturn
        {
            get { return float.Parse(GetVariable("FLMrestOnReturn")); }
            set { SetVariable("FLMrestOnReturn", value.ToString()); }
        }
        public string CarModel
        {
            get { return (GetVariable("CarModel")); }
            set { SetVariable("CarModel", value); }
        }
        public string CarRN
        {
            get { return (GetVariable("CarRN")); }
            set { SetVariable("CarRN", value); }
        }
        public string TrailerModel
        {
            get { return (GetVariable("TrailerModel")); }
            set { SetVariable("TrailerModel", value); }
        }
        public string TrailerRN
        {
            get { return (GetVariable("TrailerRN")); }
            set { SetVariable("TrailerRN", value); }
        }
        public string FIO
        {
            get { return (GetVariable("FIO")); }
            set { SetVariable("FIO", value); }
        }
        #endregion
    }
}
