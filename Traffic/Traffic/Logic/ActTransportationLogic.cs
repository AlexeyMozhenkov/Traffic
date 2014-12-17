using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public class ActTransportationLogic
    {
        public static List<ActTransportation> ReadAll()
        {
            List<ActTransportation> AllItems = new List<ActTransportation>();
            using (var db = new trafficEntities())
            {
                var query = from o in db.ActTransportation
                            select o;
                foreach (var org in query)
                {
                    AllItems.Add(org);
                }
            }
            return (AllItems);
        }

        public static List<ActTransportation> ReadFiltered(string filterString)
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
            List<ActTransportation> AllItems = new List<ActTransportation>();
            using (var db = new trafficEntities())
            {
                var query = from o in db.ActTransportation
                            where o.ActNumber == id
                            select o;
                foreach (var org in query)
                {
                    AllItems.Add(org);
                }
            }
            return (AllItems);
        }
        public static void Add(long ActNumber, long RequestNumber, string CMR, DateTime ActDate)
        {
            var Item = new ActTransportation
            {
                ActNumber = ActNumber,
                RequestNumber = RequestNumber,
                CMR = CMR,
                ActDate = ActDate
            };
            using (var db = new trafficEntities())
            {
                db.ActTransportation.Add(Item);
                db.SaveChanges();
            }
        }
        public static void Edit(long ActNumber, long RequestNumber, string CMR, DateTime ActDate)
        {
            using (var db = new trafficEntities())
            {
                var queryOrg = from o in db.ActTransportation
                               where o.ActNumber == ActNumber
                               select o;
                ActTransportation updateItem = queryOrg.First();
                updateItem.RequestNumber = RequestNumber;
                updateItem.CMR = CMR;
                updateItem.ActDate = ActDate;
                db.SaveChanges();
            }
        }

        public static void DeleteByID(long ActNumber)
        {
            using (var db = new trafficEntities())
            {
                var queryOrg = from o in db.ActTransportation
                               where o.ActNumber == ActNumber
                               select o;
                ActTransportation deleteteItem = queryOrg.First();
                db.ActTransportation.Remove(deleteteItem);
                db.SaveChanges();
            }
        }
    }
}
