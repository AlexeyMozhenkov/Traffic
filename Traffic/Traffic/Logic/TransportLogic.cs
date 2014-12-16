using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public class TransportLogic
    {
        public static List<Transport> ReadAllTransports()
        {
            List<Transport> AllTransports = new List<Transport>();
            using (var db = new trafficEntities())
            {
                var query = from t in db.Transport
                            orderby t.transportID
                            select t;
                foreach (var tr in query)
                {
                    AllTransports.Add(tr);
                }
            }
            return (AllTransports);
        }
        public static List<Transport> ReadFiltered(string filterString)
        {
            List<Transport> AllTransports = new List<Transport>();
            using (var db = new trafficEntities())
            {
                var query = from t in db.Transport
                            where t.registrationNumber.Contains(filterString)
                            orderby t.transportID
                            select t;
                foreach (var tr in query)
                {
                    AllTransports.Add(tr);
                }
            }
            return (AllTransports);
        }
        public static void AddTransport(
            long transportID, 
            string model,
            string registrationNumber,
            string VIN,
	        string transportType,
            string transportCategory,
            long? transportMakingYear,
            string ecologyClass,
	        float? maxWeight,
            float? weight,	
            string engineType,	
            float? engineVolume)
        {
            var transport = new Transport {transportID=transportID,model=model,registrationNumber=registrationNumber,VIN=VIN,
                                            transportType=transportType,transportCategory=transportCategory, transportMakingYear=transportMakingYear,ecologyClass=ecologyClass,
                                           maxWeight=maxWeight,weight=weight,engineType=engineType, engineVolume=engineVolume};
            using (var db = new trafficEntities())
            {
                db.Transport.Add(transport);
                db.SaveChanges();
            }
        }
        public static Transport SearchByID(long _transportID)
        {
            Transport tr = new Transport();
            using (var db = new trafficEntities())
            {
                //finding transport
                var query = from t in db.Transport
                            where t.transportID==_transportID
                            select t;
                foreach (var t in query)
                {
                    tr = t;
                }
            }
            return tr;
        }

        public static List<long> ListOfIDs()
        {
            List<Transport> TList = TransportLogic.ReadAllTransports();
            List<long> IDList = new List<long>();
            foreach (Transport t in TList)
            {
                IDList.Add(t.transportID);
            }
            return IDList;
        }

        public static void EditTransport(
            long transportID,
            string model,
            string registrationNumber,
            string VIN,
            string transportType,
            string transportCategory,
            long? transportMakingYear,
            string ecologyClass,
            float? maxWeight,
            float? weight,
            string engineType,
            float? engineVolume)
        {
            using (var db = new trafficEntities())
            {
                var Query = from t in db.Transport
                            where t.transportID==transportID
                            select t;
                Transport updTransport = Query.First();
                //updTransport.transportID = transportID; Unnecessary
                updTransport.model = model;
                updTransport.registrationNumber = registrationNumber;
                updTransport.VIN = VIN;
                updTransport.transportType = transportType;
                updTransport.transportCategory = transportCategory;
                updTransport.transportMakingYear = transportMakingYear;
                updTransport.ecologyClass = ecologyClass;
                updTransport.maxWeight = maxWeight;
                updTransport.weight = weight;
                updTransport.engineType = engineType;
                updTransport.engineVolume = engineVolume;
                db.SaveChanges();
            }
        }

        public static void DeleteByID(long transportID)
        {
            using (var db = new trafficEntities())
            {
                var Query = from t in db.Transport
                            where t.transportID == transportID
                            select t;
                Transport DelTransport = Query.First();
                db.Transport.Remove(DelTransport);
                db.SaveChanges();
            }
        }
    }
}
