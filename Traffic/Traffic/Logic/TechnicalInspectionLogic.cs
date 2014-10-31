using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Traffic
{
    public class TechnicalInspectionLogic
    {
        public static List<TechnicalInspection> ReadAll()
        {
            List<TechnicalInspection> All = new List<TechnicalInspection>();
            using (var db = new trafficEntities())
            {
                var query = from tc in db.TechnicalInspection
                            orderby tc.transportID
                            select tc;
                foreach (var tc in query)
                {
                    All.Add(tc);
                }
            }
            return (All);
        }
        public static void Add(long transportID, DateTime dateFrom, DateTime dateUntil, decimal Cost, decimal? tax)
        {
            var Item = new TechnicalInspection
            {
                transportID=transportID,
                dateFrom=dateFrom,
                dateUntil=dateUntil,
                Cost=Cost,
                tax=tax

            };
            using (var db = new trafficEntities())
            {
                db.TechnicalInspection.Add(Item);
                db.SaveChanges();
            }
        }


        public static void EditByID(long transportID, DateTime dateFrom, DateTime dateUntil, decimal Cost, decimal? tax)
        {
            using (var db = new trafficEntities())
            {
                var Query = from t in db.TechnicalInspection
                            where (t.transportID == transportID ) 
                            select t;
                TechnicalInspection updateItem = Query.First();
                updateItem.transportID = transportID;
                updateItem.dateFrom = dateFrom;
                updateItem.dateUntil = dateUntil;
                updateItem.Cost = Cost;
                updateItem.tax = tax;
                db.SaveChanges();
            }
        }

        public static void DeleteByID(long transportID)
        {
            using (var db = new trafficEntities())
            {
                var Query = from t in db.TechnicalInspection
                            where (t.transportID == transportID ) 
                            select t;
                TechnicalInspection deletedItem = Query.First();
                db.TechnicalInspection.Remove(deletedItem);
                db.SaveChanges();
            }
        }
    }
}