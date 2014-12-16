using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public class OrganizationsLogic
    {
        public static List<Organization> ReadAllOrganizations()
        {
            List<Organization> AllOrganizations = new List<Organization>();
            using (var db = new trafficEntities())
            {
                var query = from o in db.Organization
                            orderby o.organizationID
                            select o;
                foreach (var org in query)
                {
                    AllOrganizations.Add(org);
                }
            }
            return (AllOrganizations);
        }

        public static List<Organization> ReadFiltered(string filterString)
        {
            List<Organization> AllOrganizations = new List<Organization>();
            using (var db = new trafficEntities())
            {
                var query = from o in db.Organization
                            where o.FullTitle.Contains(filterString)
                            orderby o.organizationID
                            select o;
                foreach (var org in query)
                {
                    AllOrganizations.Add(org);
                }
            }
            return (AllOrganizations);
        }
        public static void AddOrganization(
            string AddressID,
            long OrganizationID,
            string FullTitle,
            string ShortTitle,
            string RegNumber,
            string INN,
            string KPP,
            string UNP,
            string OKPO,
            string directorID,
            string bankInfo,
            string rs,
            string ks,
            string BIK
            )
        {
            var organization = new Organization {
                addressID=AddressID,
                organizationID=OrganizationID,
                FullTitle=FullTitle,
                ShortTitle=ShortTitle,
                RegistrationNumber=RegNumber, 
                INN=INN, 
                KPP=KPP, 
                UNP=UNP,
                OKPO = OKPO,
                directorID = directorID,
                bankInfo = bankInfo,
                rs = rs,
                ks = ks,
                BIK = BIK
            };
            using (var db = new trafficEntities())
            {
                db.Organization.Add(organization);
                db.SaveChanges();
            }
        }
        public static void EditOrganization(
            string AddressID,
            long OrganizationID,
            string FullTitle,
            string ShortTitle,
            string RegNumber,
            string INN,
            string KPP,
            string UNP,
            string OKPO,
            string directorID,
            string bankInfo,
            string rs,
            string ks,
            string BIK
            )
        {
            using (var db = new trafficEntities())
            {
                var queryOrg = from o in db.Organization
                               where o.organizationID == OrganizationID
                               select o;
                Organization updOrganization = queryOrg.First();
                updOrganization.addressID = AddressID;
                updOrganization.FullTitle = FullTitle;
                updOrganization.ShortTitle = ShortTitle;
                updOrganization.RegistrationNumber = RegNumber;
                updOrganization.INN = INN;
                updOrganization.KPP = KPP;
                updOrganization.UNP = UNP;
                updOrganization.OKPO = OKPO;
                updOrganization.directorID = directorID;
                updOrganization.rs = rs;
                updOrganization.bankInfo = bankInfo;
                updOrganization.ks = ks;
                updOrganization.BIK = BIK;
                db.SaveChanges();
            }
        }



        public static Organization SearchByID(long organizationID)
        {
            Organization org = new Organization();
            using (var db = new trafficEntities())
            {
                //finding organization
                var queryOrg = from o in db.Organization
                               where o.organizationID == organizationID
                               select o;
                foreach (var o in queryOrg)
                {
                    org = o;
                }
            }
            return org;
        }
        public static void DeleteByID(long organizationID)
        {
            using (var db = new trafficEntities())
            {
                var queryOrg = from o in db.Organization
                               where o.organizationID == organizationID
                               select o;
                Organization DelOrg = queryOrg.First();
                db.Organization.Remove(DelOrg);
                db.SaveChanges();
            }
        }

        public static List<long> ListOfIDs()
        {
            List<Organization> TList = OrganizationsLogic.ReadAllOrganizations();
            List<long> IDList = new List<long>();
            foreach (Organization t in TList)
            {
                IDList.Add(t.organizationID);
            }
            return IDList;
        }
    }
}
