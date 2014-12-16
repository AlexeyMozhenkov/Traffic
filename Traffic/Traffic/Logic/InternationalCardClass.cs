using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public class InternationalCardClass
    {
        public long RegistrationID { get; set; }
        public long TransportID { get; set; }
        public string ApprovalCert { get; set; }
        public long OrganizationID { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateUntil { get; set; }
        public string Model { get; set; }
        public string RegNumber { get; set; }
        public string OrgName { get; set; }
        public InternationalCardClass()
        {

        }
        public InternationalCardClass(long registrationID, long transportID,string approvalCert, 
                                       DateTime dateFrom, DateTime dateUntil, long organizationID)
        {
            TransportID = transportID;
            Transport tr = new Transport();
            Organization org=new Organization();
            using (var db = new trafficEntities()) 
            {   
                //finding transport TODO - swap on methods
                var query = from t in db.Transport
                            where t.transportID == TransportID
                            select t;
                foreach (var t in query)
                {
                    tr = t;
                }

                //finding organization TODO - swap on methods
                var queryOrg = from o in db.Organization
                              where o.organizationID == organizationID
                            select o;
                foreach (var o in queryOrg)
                {
                    org=o;
                }
            }
            OrganizationID = org.organizationID;
            ApprovalCert = approvalCert;
            RegistrationID = registrationID;
            DateFrom = dateFrom;
            DateUntil = dateUntil;
            Model = tr.model;
            RegNumber = tr.registrationNumber;
            OrgName = org.ShortTitle;
            
        }
        public void AddToDB()
        {
            using (var db = new trafficEntities())
            {
                InternationalCard IC = new InternationalCard()
                {
                    registrationID = RegistrationID,
                    approvalCert = ApprovalCert,
                    transportID = TransportID,
                    organizationID = OrganizationID,
                    dateFromApproval = DateFrom,
                    dateUntil = DateUntil
                };
                db.InternationalCard.Add(IC);
                db.SaveChanges();
            }
        }
        public static void AddInternationalCard(long RegistrationID,
                                            string ApprovalCert,
                                            DateTime DateFrom,
                                            DateTime DateUntil,
                                            long TransportID,
                                            long OrganizationID
                                            )
        {
            using (var db = new trafficEntities())
            {
                InternationalCard IC = new InternationalCard()
                {
                    registrationID = RegistrationID,
                    approvalCert = ApprovalCert,
                    transportID = TransportID,
                    organizationID = OrganizationID,
                    dateFromApproval = DateFrom,
                    dateUntil = DateUntil
                };
                db.InternationalCard.Add(IC);
                db.SaveChanges();
            }
        }

        public static List<InternationalCardClass> ReadAllCards()
        {
            List<InternationalCardClass> ResultList = new List<InternationalCardClass>();
            using (var db=new trafficEntities())
            {
                var queryIC = from i in db.InternationalCard
                              select i;
                foreach (var i in queryIC)
                {
                    InternationalCardClass Card = new InternationalCardClass(i.registrationID,i.transportID,i.approvalCert,
                        i.dateFromApproval,i.dateUntil,i.organizationID);
                    ResultList.Add(Card);
                }
            }
            return ResultList;
        }

        public static List<InternationalCardClass> ReadFiltered(string filterString)
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
                List<InternationalCardClass> ResultList = new List<InternationalCardClass>();
                using (var db = new trafficEntities())
                {
                    var queryIC = from i in db.InternationalCard
                                  where i.organizationID == id
                                  select i;
                    foreach (var i in queryIC)
                    {
                        InternationalCardClass Card = new InternationalCardClass(i.registrationID, i.transportID, i.approvalCert,
                            i.dateFromApproval, i.dateUntil, i.organizationID);
                        ResultList.Add(Card);
                    }
                }
                return ResultList;
            
            
        
        }
        public static InternationalCardClass SearchByTransportID(long transportID)
        {
            InternationalCardClass returnParam = new InternationalCardClass();
            returnParam.TransportID = transportID;
            Transport tr = new Transport();
            Organization org = new Organization();
            InternationalCard IC = new InternationalCard();
            using (var db = new trafficEntities())
            {
                //finding transport TODO - swap on methods
                var query = from t in db.Transport
                            where t.transportID == returnParam.TransportID
                            select t;
                foreach (var t in query)
                {
                    tr = t;
                }
                //finding IC TODO - swap on methods
                var queryIC = from i in db.InternationalCard
                              where i.transportID == returnParam.TransportID
                            select i;
                foreach (var i in queryIC)
                {
                    IC=i;
                }
                //finding organization TODO - swap on methods
                var queryOrg = from o in db.Organization
                               where o.organizationID == IC.organizationID
                               select o;
                foreach (var o in queryOrg)
                {
                    org = o;
                }
            }
            returnParam.RegistrationID = IC.registrationID;
            returnParam.DateFrom = IC.dateFromApproval;
            returnParam.DateUntil = IC.dateUntil;
            returnParam.Model = tr.model;
            returnParam.RegNumber = tr.registrationNumber;
            returnParam.OrgName = org.ShortTitle;
            return returnParam;
        }
        public static void DeleteByTransportID(long transportID)
        {
            using (var db = new trafficEntities())
            {
                var Query = from t in db.InternationalCard
                            where t.transportID == transportID
                            select t;
                InternationalCard DelCard = Query.First();
                db.InternationalCard.Remove(DelCard);
                db.SaveChanges();
            }
        }
        public static void EditByTransportID(
            long registrationID,
            string approvalCert,
            DateTime dateFrom,
            DateTime dateUntil,
            long transportID,
            long organizationID)
        {
            using (var db = new trafficEntities())
            {
                var Query = from t in db.InternationalCard
                            where t.transportID == transportID
                            select t;
                InternationalCard DelCard = Query.First();
                db.InternationalCard.Remove(DelCard);
                InternationalCard CardClass = new InternationalCard()
                {
                    registrationID=registrationID,
                    transportID=transportID,
                    approvalCert=approvalCert,
                    dateFromApproval=dateFrom,
                    dateUntil=dateUntil, 
                    organizationID=organizationID
                };
                db.InternationalCard.Add(CardClass);
                db.SaveChanges();
            }
        }
    }
}
