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
                            select o;
                foreach (var org in query)
                {
                    AllItems.Add(org);
                }
            }
            return (AllItems);
        }

        public static List<Contracts> ReadFiltered(string filterString)
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
            List<Contracts> AllItems = new List<Contracts>();
            using (var db = new trafficEntities())
            {
                var query = from o in db.Contracts
                            where o.contractID == id
                            select o;
                foreach (var org in query)
                {
                    AllItems.Add(org);
                }
            }
            return (AllItems);
        }
        public static void Add(long contractID, long PerformerID, long CustomerID, string ContractNumber, DateTime DateFrom, DateTime DateUntil, string Place)
        {
            var Item = new Contracts
            {
                contractID = contractID,
                PerformerID = PerformerID,
                CustomerID = CustomerID,
                ContractNumber = ContractNumber,
                DateFrom = DateFrom,
                DateUntil = DateUntil,
                Place = Place
            };
            using (var db = new trafficEntities())
            {
                db.Contracts.Add(Item);
                db.SaveChanges();
            }
        }
        public static void Edit(long contractID, long PerformerID, long CustomerID, string ContractNumber, DateTime DateFrom, DateTime DateUntil, string Place)
        {
            using (var db = new trafficEntities())
            {
                var queryOrg = from o in db.Contracts
                               where o.contractID == contractID
                               select o;
                Contracts updateItem = queryOrg.First();
                updateItem.contractID = contractID;
                updateItem.PerformerID = PerformerID;
                updateItem.CustomerID = CustomerID;
                updateItem.ContractNumber = ContractNumber;
                updateItem.DateFrom = DateFrom;
                updateItem.DateUntil = DateUntil;
                updateItem.Place = Place;
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
