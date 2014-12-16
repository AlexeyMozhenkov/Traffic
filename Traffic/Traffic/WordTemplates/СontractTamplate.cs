using System;
using System.IO;
using System.Linq;
namespace Traffic.WordTemplates
{
    public class СontractTamplate : BaseWordTemplate, IWordTemplate
    {
        private const string FileName = "Сontract.dotx";
        public СontractTamplate() : base(FileName) { }
        public СontractTamplate(string folder) : base(Path.Combine(folder, FileName)) { }
        public void Fill(long id)
        {
            using (var db = new trafficEntities())
            {
                //var tbl = GetTable("InvoiceTable");
                var infoContract = (from item in db.Contracts
                    where item.contractID == id
                    select item).SingleOrDefault();
                if (infoContract == null) return;
                ContractNumber = infoContract.ContractNumber;
                DateFrom = (DateTime)infoContract.DateFrom;
                DateUntil = (DateTime)infoContract.DateUntil;
                Place = infoContract.Place;

                var infoPerformer = (from item in db.Organization
                                     where item.organizationID == infoContract.PerformerID
                                    select item).SingleOrDefault();
                if (infoPerformer == null) return;
                AddressID = infoPerformer.addressID;
                FullTitle = infoPerformer.FullTitle;
                ShortTitle = infoPerformer.ShortTitle;
                RegNumber = infoPerformer.RegistrationNumber;
                INN = infoPerformer.INN;
                KPP = infoPerformer.KPP;
                UNP = infoPerformer.UNP;
                OKPO = infoPerformer.OKPO;
                directorID = infoPerformer.directorID;
                bankInfo = infoPerformer.bankInfo;
                rs = infoPerformer.rs;
                ks = infoPerformer.ks;
                BIK = infoPerformer.BIK;


                var infoCustomer = (from item in db.Organization
                                     where item.organizationID == infoContract.CustomerID
                                     select item).SingleOrDefault();
                if (infoCustomer == null) return;
                AddressIDCustomer = infoCustomer.addressID;
                FullTitleCustomer = infoCustomer.FullTitle;
                ShortTitleCustomer = infoCustomer.ShortTitle;
                RegNumberCustomer = infoCustomer.RegistrationNumber;
                INNCustomer = infoCustomer.INN;
                KPPCustomer = infoCustomer.KPP;
                UNPCustomer = infoCustomer.UNP;
                OKPOCustomer = infoCustomer.OKPO;
                directorIDCustomer = infoCustomer.directorID;
                bankInfoCustomer = infoCustomer.bankInfo;
                rsCustomer = infoCustomer.rs;
                ksCustomer = infoCustomer.ks;
                BIKCustomer = infoCustomer.BIK;
            }
        }

        #region AutoProperties

        public string ContractNumber
        {
            get { return GetVariable("ContractNumber"); }
            set { SetVariable("ContractNumber", value); }
        }

        public DateTime DateFrom
        {
            get { return DateTime.Parse(GetVariable("DateFrom")); }
            set { SetVariable("DateFrom", value.ToString("dd.MM.yyyy")); }
        }

        public DateTime DateUntil
        {
            get { return DateTime.Parse(GetVariable("DateUntil")); }
            set { SetVariable("DateUntil", value.ToString("dd.MM.yyyy")); }
        }
        public string Place
        {
            get { return GetVariable("Place"); }
            set { SetVariable("Place", value); }
        }

        public string AddressID
        {
            get { return GetVariable("AddressID"); }
            set { SetVariable("AddressID", value); }
        }

        public string FullTitle 
        {
            get { return GetVariable("FullTitle"); }
            set { SetVariable("FullTitle", value); }
        }
        public string ShortTitle
        {
            get { return GetVariable("ShortTitle"); }
            set { SetVariable("ShortTitle", value); }
        }
        public string RegNumber
        {
            get { return GetVariable("RegNumber"); }
            set { SetVariable("RegNumber", value); }
        }
        public string INN
        {
            get { return GetVariable("INN"); }
            set { SetVariable("INN", value); }
        }
        public string KPP
        {
            get { return GetVariable("KPP"); }
            set { SetVariable("KPP", value); }
        }
        public string UNP
        {
            get { return GetVariable("UNP"); }
            set { SetVariable("UNP", value); }
        }
        public string OKPO
        {
            get { return GetVariable("OKPO"); }
            set { SetVariable("OKPO", value); }
        }
        public string directorID
        {
            get { return GetVariable("directorID"); }
            set { SetVariable("directorID", value); }
        }
        public string bankInfo
        {
            get { return GetVariable("bankInfo"); }
            set { SetVariable("bankInfo", value); }
        }
        public string rs
        {
            get { return GetVariable("rs"); }
            set { SetVariable("rs", value); }
        }
        public string ks
        {
            get { return GetVariable("ks"); }
            set { SetVariable("ks", value); }
        }

        public string BIK
        {
            get { return GetVariable("BIK"); }
            set { SetVariable("BIK", value); }
        }

        public string AddressIDCustomer
        {
            get { return GetVariable("AddressIDCustomer"); }
            set { SetVariable("AddressIDCustomer", value); }
        }

        public string FullTitleCustomer
        {
            get { return GetVariable("FullTitleCustomer"); }
            set { SetVariable("FullTitleCustomer", value); }
        }
        public string ShortTitleCustomer
        {
            get { return GetVariable("ShortTitleCustomer"); }
            set { SetVariable("ShortTitleCustomer", value); }
        }
        public string RegNumberCustomer
        {
            get { return GetVariable("RegNumberCustomer"); }
            set { SetVariable("RegNumberCustomer", value); }
        }
        public string INNCustomer
        {
            get { return GetVariable("INNCustomer"); }
            set { SetVariable("INNCustomer", value); }
        }
        public string KPPCustomer
        {
            get { return GetVariable("KPPCustomer"); }
            set { SetVariable("KPPCustomer", value); }
        }
        public string UNPCustomer
        {
            get { return GetVariable("UNPCustomer"); }
            set { SetVariable("UNPCustomer", value); }
        }
        public string OKPOCustomer
        {
            get { return GetVariable("OKPOCustomer"); }
            set { SetVariable("OKPOCustomer", value); }
        }
        public string directorIDCustomer
        {
            get { return GetVariable("directorIDCustomer"); }
            set { SetVariable("directorIDCustomer", value); }
        }
        public string bankInfoCustomer
        {
            get { return GetVariable("bankInfoCustomer"); }
            set { SetVariable("bankInfoCustomer", value); }
        }
        public string rsCustomer
        {
            get { return GetVariable("rsCustomer"); }
            set { SetVariable("rsCustomer", value); }
        }
        public string ksCustomer
        {
            get { return GetVariable("ksCustomer"); }
            set { SetVariable("ksCustomer", value); }
        }

        public string BIKCustomer
        {
            get { return GetVariable("BIKCustomer"); }
            set { SetVariable("BIKCustomer", value); }
        }

        #endregion
    }
}
