using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public class RequestsLogic
    {
        public static List<Request> ReadAll()
        {
            List<Request> AllItems = new List<Request>();
            using (var db = new trafficEntities())
            {
                var query = from o in db.Request
                            select o;
                foreach (var org in query)
                {
                    AllItems.Add(org);
                }
            }
            return (AllItems);
        }

        public static List<Request> ReadFiltered(string filterString)
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
            List<Request> AllItems = new List<Request>();
            using (var db = new trafficEntities())
            {
                var query = from o in db.Request
                            where o.RequestNumber == id
                            select o;
                foreach (var org in query)
                {
                    AllItems.Add(org);
                }
            }
            return (AllItems);
        }
        public static void Add(long RequestNumber, long contractID, long transportID, DateTime RequestDate, string Sender, string Recipient, string Shipment, string OffloadingPlace, string NumberOfSeats, string Packing, decimal Cost, string SpecialNotes)
        {
            var Item = new Request
            {
                RequestNumber=RequestNumber,
                contractID = contractID,
                transportID = transportID,
                RequestDate = RequestDate,
                Sender = Sender,
                Recipient = Recipient,
                Shipment = Shipment,
                OffloadingPlace = OffloadingPlace,
                NumberOfSeats = NumberOfSeats,
                Packing = Packing,
                Cost = Cost,
                SpecialNotes = SpecialNotes
            };
            using (var db = new trafficEntities())
            {
                db.Request.Add(Item);
                db.SaveChanges();
            }
        }
        public static void Edit(long RequestNumber, long contractID, long transportID, DateTime RequestDate, string Sender, string Recipient, string Shipment, string OffloadingPlace, string NumberOfSeats, string Packing, decimal Cost, string SpecialNotes)
        {
            using (var db = new trafficEntities())
            {
                var queryOrg = from o in db.Request
                               where o.RequestNumber == RequestNumber
                               select o;
                Request updateItem = queryOrg.First();
                updateItem.contractID = contractID;
                updateItem.transportID = transportID;
                updateItem.RequestDate = RequestDate;
                updateItem.Sender = Sender;
                updateItem.Recipient = Recipient;
                updateItem.Shipment = Shipment;
                updateItem.OffloadingPlace = OffloadingPlace;
                updateItem.NumberOfSeats = NumberOfSeats;
                updateItem.Packing = Packing;
                updateItem.Cost = Cost;
                updateItem.SpecialNotes = SpecialNotes;
                
                db.SaveChanges();
            }
        }

        public static void DeleteByID(long RequestNumber)
        {
            using (var db = new trafficEntities())
            {
                var queryOrg = from o in db.Request
                               where o.RequestNumber == RequestNumber
                               select o;
                Request deleteteItem = queryOrg.First();
                db.Request.Remove(deleteteItem);
                db.SaveChanges();
            }
        }
    }
}
