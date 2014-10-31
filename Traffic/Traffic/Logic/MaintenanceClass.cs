using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public class MaintenanceClass
    {
        public long maintenanceID { get; set; }
        public long transportID { get; set; }
        public DateTime dateFrom { get; set; }
        public DateTime dateUntil { get; set; }

        public long typeCostID { get; set; }
        public bool service { get; set; }
        public bool repair { get; set; }
        public decimal cost { get; set; }

        public MaintenanceClass()
        {
            
        }
        public MaintenanceClass(long MaintenanceID)
        {
            maintenanceID = MaintenanceID;
            Maintenance _maintenance=MaintenanceLogic.SearchByID(maintenanceID);
            transportID = _maintenance.transportID;
            dateFrom = _maintenance.dateFrom;
            dateUntil = _maintenance.dateUntil;
            typeCostID = _maintenance.typeCostID;
            cost = (decimal)_maintenance.cost;
            TypeCost TC = TypeCostLogic.SearchByID(_maintenance.typeCostID);
            service = (bool)TC.service;
            repair = (bool)TC.repair;
        }
        public static List<MaintenanceClass> ReadAllMaintenanceClasses()
        {
            List<MaintenanceClass> AllMaintenanceClasses = new List<MaintenanceClass>();
            List<Maintenance> AllMaintenances = MaintenanceLogic.ReadAllMaintenances();
            foreach (var m in AllMaintenances)
            {
                MaintenanceClass MC = new MaintenanceClass(m.maintenanceID);
                AllMaintenanceClasses.Add(MC);
            }
            return AllMaintenanceClasses;
        }
        public static void AddMaintenanceClass(long maintenanceID,long transportID,DateTime dateFrom,DateTime dateUntil,long typeCostID,decimal cost)
        {
            MaintenanceLogic.AddMaintenance(maintenanceID,transportID,dateFrom,dateUntil,typeCostID,cost);
        }


        public static void EditByID(long maintenanceID,long transportID, DateTime dateFrom, DateTime dateUntil, long typeCostID, decimal cost)
        {
            using (var db = new trafficEntities())
            {
                var Query = from t in db.Maintenance
                            where t.maintenanceID == maintenanceID
                            select t;
                Maintenance DelMaintenance = Query.First();
                db.Maintenance.Remove(DelMaintenance);
                Maintenance Maintenance = new Maintenance()
                {
                    maintenanceID=maintenanceID,
                    transportID=transportID,
                    dateFrom=dateFrom,
                    dateUntil=dateUntil,
                    typeCostID=typeCostID,
                    cost=cost
                };
                db.Maintenance.Add(Maintenance);
                db.SaveChanges();
            }
        }
        public static void DeleteByID(long maintenanceID)
        {
            MaintenanceLogic.DeleteByID(maintenanceID);
        }

    }
}
