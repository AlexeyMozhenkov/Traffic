using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public class TypeCostLogic
    {
        public static List<TypeCost> ReadAllTypeCosts()
        {
            List<TypeCost> AllTypeCosts = new List<TypeCost>();
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
            var TypeCost = new TypeCost { typeCostName = TypeCostName, service = Service, repair = Repair };
            using (var db = new trafficEntities())
            {
                db.TypeCost.Add(TypeCost);
                db.SaveChanges();
            }
        }

        public static TypeCost SearchByID(long TypeCostID)
        {
            TypeCost TC = new TypeCost();
            using (var db = new trafficEntities())
            {
                //finding TypeCost
                var queryTypeCost = from tc in db.TypeCost
                                    where tc.typeCostID == TypeCostID
                               select tc;
                foreach (var tc in queryTypeCost)
                {
                    TC = tc;
                }
            }
            return TC;
        }
        public static void DeleteByID(long TypeCostID)
        {
            TypeCost TC = new TypeCost();
            using (var db = new trafficEntities())
            {
                //finding TypeCost
                var queryTypeCost = from tc in db.TypeCost
                                    where tc.typeCostID == TypeCostID
                                    select tc;
                TC = queryTypeCost.First();
                db.TypeCost.Remove(TC);
                db.SaveChanges();
            }
        }

    }
}
