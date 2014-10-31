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
        public static void AddReport( long organizationID, long? routeID, long transportID, long tableNumber, string status, string notes, string location)
        {
            var Item = new transportStateReport {
                //reportID = reportID,
                organizationID = organizationID,
                routeID = routeID,
                transportID = transportID,
                tableNumber = tableNumber,
                status = status,
                notes = notes,
                location = location
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

        public static void EditByID(long reportID, long organizationID, long? routeID, long transportID, long tableNumber, string status, string notes, string location)
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
