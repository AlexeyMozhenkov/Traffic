using System.IO;
using System.Linq;
namespace Traffic.WordTemplates
{
    public class СontractTamplate : BaseWordTemplate, IWordTemplate
    {
        private const string FileName = "OrganizationCard.dotx";
        public СontractTamplate() : base(FileName) { }
        public СontractTamplate(string folder) : base(Path.Combine(folder, FileName)) { }
        public void Fill(long id)
        {
            using (var db = new trafficEntities())
            {
                //var tbl = GetTable("InvoiceTable");
                var infoOrganization = (from item in db.Organization
                    where item.organizationID == id
                    select item).SingleOrDefault();
                if (infoOrganization == null) return;
                AddressID = infoOrganization.addressID;
                FullTitle=infoOrganization.FullTitle;
                ShortTitle = infoOrganization.ShortTitle;
                RegNumber = infoOrganization.RegistrationNumber;
                INN = infoOrganization.INN;
                KPP = infoOrganization.KPP;
                UNP = infoOrganization.UNP;
                OKPO = infoOrganization.OKPO;
                directorID = infoOrganization.directorID;
                bankInfo = infoOrganization.bankInfo;
                rs = infoOrganization.rs;
                ks = infoOrganization.ks;
                BIK = infoOrganization.BIK;
            }
        }

        #region AutoProperties

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

        #endregion
    }
}
