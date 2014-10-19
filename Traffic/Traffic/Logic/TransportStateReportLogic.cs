using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//TODO - NOT RDY!
namespace Traffic
{
    class TransportStateReportLogic
    {/*
        public static List<transportStateReport> ReadAllTransportStateReports()
        {
            List<transportStateReport> AllTypeCosts = new List<transportStateReport>();
            using (var db = new trafficEntities())
            {
                var query = from tc in db.TypeCost
                            orderby tc.typeCostID
                            select tc;
                foreach (var tc in query)
                {
                    AllTypeCosts.Add(tc);
                }
            }
            return (AllTypeCosts);
        }
        public static void AddTypeCost(string TypeCostName, bool Service, bool Repair)
        {
            var TypeCost = new transportStateReport { typeCostName = TypeCostName, service = Service, repair = Repair };
            using (var db = new trafficEntities())
            {
                db.TypeCost.Add(TypeCost);
                db.SaveChanges();
            }
        }

        public static transportStateReport SearchByID(long TypeCostID)
        {
            transportStateReport TC = new transportStateReport();
            using (var db = new trafficEntities())
            {
                //finding TypeCost
                var queryTypeCost = from tc in db.TypeCost
                                    select tc;
                queryTypeCost.Where(tc => tc.typeCostID == TypeCostID);
                foreach (var tc in queryTypeCost)
                {
                    TC = tc;
                }
            }
            return TC;
        }*/
    }
}
