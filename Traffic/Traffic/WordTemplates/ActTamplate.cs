using System;
using System.IO;
using System.Linq;
namespace Traffic.WordTemplates
{
    public class ActTamplate : BaseWordTemplate, IWordTemplate
    {
        private const string FileName = "Act.dotx";
        public ActTamplate() : base(FileName) { }
        public ActTamplate(string folder) : base(Path.Combine(folder, FileName)) { }
        public void Fill(long id)
        {
            using (var db = new trafficEntities())
            {
                var infoAct = (from item in db.ActTransportation
                               where item.ActNumber == id
                                   select item).SingleOrDefault();
                if (infoAct == null) return;
                ActNumber = infoAct.ActNumber;
                ActDate = infoAct.ActDate;
                CMR = infoAct.CMR;

                var infoRequest = (from item in db.Request
                    where item.RequestNumber == infoAct.RequestNumber
                    select item).SingleOrDefault();
                if (infoRequest == null) return;
                RequestNumber = infoRequest.RequestNumber;
                RequestDate = infoRequest.RequestDate;
                Sender = infoRequest.Sender;
                Recipient = infoRequest.Recipient;
                Shipment = infoRequest.Shipment;
                OffloadingPlace = infoRequest.OffloadingPlace;
                NumberOfSeats = infoRequest.NumberOfSeats;
                Packing = infoRequest.Packing;
                Cost = infoRequest.Cost;
                SpecialNotes = infoRequest.SpecialNotes;

                var infoContract = (from item in db.Contracts
                                    where item.contractID == infoRequest.contractID
                                    select item).SingleOrDefault();
                if (infoContract == null) return;
                ContractNumber = infoContract.ContractNumber;
                DateFrom = (DateTime)infoContract.DateFrom;

                var infoPerformer = (from item in db.Organization
                                     where item.organizationID == infoContract.PerformerID
                                     select item).SingleOrDefault();
                if (infoPerformer == null) return;    
                ShortTitle = infoPerformer.ShortTitle;
                directorID = infoPerformer.directorID;
               

                var infoCustomer = (from item in db.Organization
                                    where item.organizationID == infoContract.CustomerID
                                    select item).SingleOrDefault();
                if (infoCustomer == null) return;
                ShortTitleCustomer = infoCustomer.ShortTitle;
                directorIDCustomer = infoCustomer.directorID;

                var infoTransport = (from item in db.Transport
                                     where item.transportID == infoRequest.transportID
                                    select item).SingleOrDefault();
                if (infoTransport == null) return;
                AboutTransport = string.Format("{0} {1}/{2}/{3} литра", infoTransport.transportType, infoTransport.model, infoTransport.registrationNumber, infoTransport.engineVolume);
            }
        }

        #region AutoProperties

        public long ActNumber
        {
            get { return long.Parse(GetVariable("ActNumber")); }
            set { SetVariable("ActNumber", value.ToString()); }
        }

        public DateTime ActDate
        {
            get { return DateTime.Parse(GetVariable("ActDate")); }
            set { SetVariable("ActDate", value.ToString("dd.MM.yyyy")); }
        }

        public string CMR
        {
            get { return GetVariable("CMR"); }
            set { SetVariable("CMR", value); }
        }
        public long RequestNumber
        {
            get { return long.Parse(GetVariable("RequestNumber")); }
            set { SetVariable("RequestNumber", value.ToString()); }
        }

        public DateTime RequestDate
        {
            get { return DateTime.Parse(GetVariable("RequestDate")); }
            set { SetVariable("RequestDate", value.ToString("dd.MM.yyyy")); }
        }
        public string Sender
        {
            get { return GetVariable("Sender"); }
            set { SetVariable("Sender", value); }
        }
        public string Recipient
        {
            get { return GetVariable("Recipient"); }
            set { SetVariable("Recipient", value); }
        }
        public string Shipment
        {
            get { return GetVariable("Shipment"); }
            set { SetVariable("Shipment", value); }
        }
        public string OffloadingPlace
        {
            get { return GetVariable("OffloadingPlace"); }
            set { SetVariable("OffloadingPlace", value); }
        }
        public string NumberOfSeats
        {
            get { return GetVariable("NumberOfSeats"); }
            set { SetVariable("NumberOfSeats", value); }
        }
        public string Packing
        {
            get { return GetVariable("Packing"); }
            set { SetVariable("Packing", value); }
        }
        public decimal Cost
        {
            get { return decimal.Parse(GetVariable("Cost")); }
            set { SetVariable("Cost", value.ToString()); }
        }
        public string SpecialNotes
        {
            get { return GetVariable("SpecialNotes"); }
            set { SetVariable("SpecialNotes", value); }
        }

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

        public string ShortTitle
        {
            get { return GetVariable("ShortTitle"); }
            set { SetVariable("ShortTitle", value); }
        }
        public string directorID
        {
            get { return GetVariable("directorID"); }
            set { SetVariable("directorID", value); }
        }
        public string ShortTitleCustomer
        {
            get { return GetVariable("ShortTitleCustomer"); }
            set { SetVariable("ShortTitleCustomer", value); }
        }
        public string directorIDCustomer
        {
            get { return GetVariable("directorIDCustomer"); }
            set { SetVariable("directorIDCustomer", value); }
        }

        public string AboutTransport
        {
            get { return GetVariable("AboutTransport"); }
            set { SetVariable("AboutTransport", value); }
        }

        #endregion
    }
}
