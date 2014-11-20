using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public class ContractsLogic
    {
        public static List<Contracts> ReadAll()
        {
            List<Contracts> AllItems = new List<Contracts>();
            using (var db = new trafficEntities())
            {
                var query = from o in db.Contracts
                            orderby o.organizationID
                            select o;
                foreach (var org in query)
                {
                    AllItems.Add(org);
                }
            }
            return (AllItems);
        }
        public static void Add(long contractID, long organizationID, string contractNumber, DateTime contractDate, string contractType)
        {
            var Item = new Contracts
            {
                contractID = contractID,
                organizationID = organizationID,
                contractNumber = contractNumber,
                contractDate = contractDate,
                contractType = contractType
            };
            using (var db = new trafficEntities())
            {
                db.Contracts.Add(Item);
                db.SaveChanges();
            }
        }
        public static void Edit(long contractID, long organizationID, string contractNumber, DateTime contractDate, string contractType)
        {
            using (var db = new trafficEntities())
            {
                var queryOrg = from o in db.Contracts
                               where o.contractID == contractID
                               select o;
                Contracts updateItem = queryOrg.First();
                updateItem.contractID = contractID;
                updateItem.organizationID = organizationID;
                updateItem.contractNumber = contractNumber;
                updateItem.contractDate = contractDate;
                updateItem.contractType = contractType;
                db.SaveChanges();
            }
        }

        public static void DeleteByID(long contractID)
        {
            using (var db = new trafficEntities())
            {
                var queryOrg = from o in db.Contracts
                               where o.contractID == contractID
                               select o;
                Contracts deleteteItem = queryOrg.First();
                db.Contracts.Remove(deleteteItem);
                db.SaveChanges();
            }
        }
    }
}
