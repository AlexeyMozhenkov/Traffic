using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Traffic
{

    public class WaybillsLogic
    {
        public static List<Waybills> ReadAll()
        {
            List<Waybills> AllWaybills = new List<Waybills>();
            using (var db = new trafficEntities())
            {
                var query = from w in db.Waybills
                            orderby w.waybillID
                            select w;
                foreach (var w in query)
                {
                    AllWaybills.Add(w);
                }
            }
            return (AllWaybills);
        }
        public static void Add(
        long waybillID,
        int waybillNumber,
        DateTime creationDate,
        //long carrierID,
        long carID,
        int trailerID,
        string driversTableNumber,
        double speedometerOnDeparture,
        double speedometerOnReturn,
        DateTime departureDateShedule,
        TimeSpan departureTimeShedule,
        DateTime departureDateFact,
        TimeSpan departureTimeFact,
        DateTime returnDateShedule,
        TimeSpan returnTimeShedule,
        DateTime returnDateFact,
        TimeSpan returnTimeFact,
        double zeroMileage,
        double engineTime,
        double soecialEquipmentTime,
        double FLMrestOnDeparture,
        double FLMrestOnReturn)
        {
            var Waybill = new Waybills
            {
                waybillID = waybillID,
                waybillNumber = waybillNumber,
                creationDate = creationDate,
                //carrierID = carrierID,
                carID = carID,
                trailerID = trailerID,
                driversTableNumber = driversTableNumber,
                speedometerOnDeparture = speedometerOnDeparture,
                speedometerOnReturn = speedometerOnReturn,
                departureDateShedule = departureDateShedule,
                departureTimeShedule = departureTimeShedule,
                departureDateFact = departureDateFact,
                departureTimeFact = departureTimeFact,
                returnDateShedule = returnDateShedule,
                returnTimeShedule = returnTimeShedule,
                returnDateFact = returnDateFact,
                returnTimeFact = returnTimeFact,
                zeroMileage = zeroMileage,
                engineTime = engineTime,
                soecialEquipmentTime = soecialEquipmentTime,
                FLMrestOnDeparture = FLMrestOnDeparture,
                FLMrestOnReturn = FLMrestOnReturn
            };
            using (var db = new trafficEntities())
            {
                db.Waybills.Add(Waybill);
                db.SaveChanges();
            }
        }
        public static Waybills SearchByID(long _WaybillID)
        {
            Waybills wb = new Waybills();
            using (var db = new trafficEntities())
            {
                //finding Waybill
                var query = from w in db.Waybills
                            where w.waybillID == _WaybillID
                            select w;
                foreach (var w in query)
                {
                    wb = w;
                }
            }
            return wb;
        }

        public static List<long> ListOfIDs()
        {
            List<Waybills> TList = WaybillsLogic.ReadAll();
            List<long> IDList = new List<long>();
            foreach (Waybills w in TList)
            {
                IDList.Add(w.waybillID);
            }
            return IDList;
        }

        public static void Edit(
        long waybillID,
        int waybillNumber,
        DateTime creationDate,
        //long carrierID,
        long carID,
        int trailerID,
        string driversTableNumber,
        double speedometerOnDeparture,
        double speedometerOnReturn,
        DateTime departureDateShedule,
        TimeSpan departureTimeShedule,
        DateTime departureDateFact,
        TimeSpan departureTimeFact,
        DateTime returnDateShedule,
        TimeSpan returnTimeShedule,
        DateTime returnDateFact,
        TimeSpan returnTimeFact,
        double zeroMileage,
        double engineTime,
        double soecialEquipmentTime,
        double FLMrestOnDeparture,
        double FLMrestOnReturn)
        {
            using (var db = new trafficEntities())
            {
                var Query = from w in db.Waybills
                            where w.waybillID == waybillID
                            select w;
                Waybills updWaybill = Query.First();
                updWaybill.waybillID = waybillID;
                updWaybill.waybillNumber = waybillNumber;
                updWaybill.creationDate = creationDate;
                //updWaybill.carrierID = carrierID;
                updWaybill.carID = carID;
                updWaybill.trailerID = trailerID;
                updWaybill.driversTableNumber = driversTableNumber;
                updWaybill.speedometerOnDeparture = speedometerOnDeparture;
                updWaybill.speedometerOnReturn = speedometerOnReturn;
                updWaybill.departureDateShedule = departureDateShedule;
                updWaybill.departureTimeShedule = departureTimeShedule;
                updWaybill.departureDateFact = departureDateFact;
                updWaybill.departureTimeFact = departureTimeFact;
                updWaybill.returnDateShedule = returnDateShedule;
                updWaybill.returnTimeShedule = returnTimeShedule;
                updWaybill.returnDateFact = returnDateFact;
                updWaybill.returnTimeFact = returnTimeFact;
                updWaybill.zeroMileage = zeroMileage;
                updWaybill.engineTime = engineTime;
                updWaybill.soecialEquipmentTime = soecialEquipmentTime;
                updWaybill.FLMrestOnDeparture = FLMrestOnDeparture;
                updWaybill.FLMrestOnReturn = FLMrestOnReturn;
                db.SaveChanges();
            }
        }

        public static void DeleteByID(long WaybillID)
        {
            using (var db = new trafficEntities())
            {
                var Query = from t in db.Waybills
                            where t.waybillID == WaybillID
                            select t;
                Waybills DelWaybill = Query.First();
                db.Waybills.Remove(DelWaybill);
                db.SaveChanges();
            }
        }
    }
}