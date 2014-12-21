using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    class TransportStateReportLogic
    {
        public static List<transportStateReport> ReadAllTransportStateReports()
        {
            List<transportStateReport> All = new List<transportStateReport>();
            using (var db = new trafficEntities())
            {
                var query = from tc in db.transportStateReport
                            orderby tc.reportID
                            select tc;
                foreach (var tc in query)
                {
                    All.Add(tc);
                }
            }
            return (All);
        }

        public static List<transportStateReport> ReadFiltered(string filterString)
        {
            long id;
            try
            {
                id = Int64.Parse(filterString);
            }
            catch (Exception ex)
            {
                id = 0;
                //throw ex;     
            }
            List<transportStateReport> All = new List<transportStateReport>();
            using (var db = new trafficEntities())
            {
                var query = from tc in db.transportStateReport
                            where tc.organizationID == id
                            orderby tc.reportID
                            select tc;
                foreach (var tc in query)
                {
                    All.Add(tc);
                }
            }
            return (All);
        }
        public static void AddReport(long organizationID, long routeID, long transportID, string tableNumber, string status, string notes, string location, DateTime DepartureDate, DateTime DeliveryPeriod, string Shipper, string PointOfShipment, string PointOfDelivery, string Customer, string Shipment)
        {
            var Item = new transportStateReport {
                //reportID = reportID,
                organizationID = organizationID,
                routeID = routeID,
                transportID = transportID,
                tableNumber = tableNumber,
                status = status,
                notes = notes,
                location = location,
                DepartureDate = DepartureDate,
                DeliveryPeriod = DeliveryPeriod,
                Shipper = Shipper,
                PointOfShipment = PointOfShipment,
                PointOfDelivery = PointOfDelivery,
                Customer = Customer,
                Shipment = Shipment
            };
            using (var db = new trafficEntities())
            {
                db.transportStateReport.Add(Item);
                db.SaveChanges();
            }
        }

        public static transportStateReport SearchByID(long reportID)
        {
            transportStateReport TC = new transportStateReport();
            using (var db = new trafficEntities())
            {
                //finding TypeCost
                var queryTypeCost = from tc in db.transportStateReport
                                    select tc;
                queryTypeCost.Where(tc => tc.reportID == reportID);
                foreach (var tc in queryTypeCost)
                {
                    TC = tc;
                }
            }
            return TC;
        }

        public static void EditByID(long reportID, long organizationID, long routeID, long transportID, string tableNumber, string status, string notes, string location, DateTime DepartureDate, DateTime DeliveryPeriod, string Shipper, string PointOfShipment, string PointOfDelivery, string Customer, string Shipment)
        {
            using (var db = new trafficEntities())
            {
                var Query = from t in db.transportStateReport
                            where t.reportID == reportID
                            select t;
                transportStateReport updateItem = Query.First();

                updateItem.organizationID = organizationID;
                updateItem.routeID = routeID;
                updateItem.transportID = transportID;
                updateItem.tableNumber = tableNumber;
                updateItem.status = status;
                updateItem.notes = notes;
                updateItem.location = location;
                updateItem.DepartureDate = DepartureDate;
                updateItem.DeliveryPeriod = DeliveryPeriod;
                updateItem.Shipper = Shipper;
                updateItem.PointOfShipment = PointOfShipment;
                updateItem.PointOfDelivery = PointOfDelivery;
                updateItem.Customer = Customer;
                updateItem.Shipment = Shipment;

                db.SaveChanges();
            }
        }

        public static void DeleteByID(long reportID)
        {
            using (var db = new trafficEntities())
            {
                var Query = from t in db.transportStateReport
                            where t.reportID == reportID
                            select t;
                transportStateReport deletedItem = Query.First();
                db.transportStateReport.Remove(deletedItem);
                db.SaveChanges();
            }
        }
    }
}
