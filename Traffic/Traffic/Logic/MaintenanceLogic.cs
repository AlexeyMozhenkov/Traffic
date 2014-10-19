using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traffic
{
    public class MaintenanceLogic
    {
        public static List<Maintenance> ReadAllMaintenances()
        {
            List<Maintenance> AllMaintenances = new List<Maintenance>();
            using (var db = new trafficEntities())
            {
                var query = from m in db.Maintenance
                            orderby m.typeCostID
                            select m;
                foreach (var m in query)
                {
                    AllMaintenances.Add(m);
                }
            }
            return (AllMaintenances);
        }
        public static void AddMaintenance(long maintenanceID,long transportID,DateTime dateFrom,DateTime dateUntil,long typeCostID,decimal cost)
        {
            var Maintenance = new Maintenance {maintenanceID=maintenanceID, transportID=transportID, dateFrom=dateFrom, dateUntil=dateUntil, typeCostID=typeCostID,cost=(decimal)cost};
            using (var db = new trafficEntities())
            {
                db.Maintenance.Add(Maintenance);
                db.SaveChanges();
            }
        }

        public static Maintenance SearchByID(long MaintenanceID)
        {
            Maintenance Maintenance = new Maintenance();
            using (var db = new trafficEntities())
            {
                //finding Maintenance
                var queryMaintenance = from m in db.Maintenance
                                       where m.maintenanceID == MaintenanceID
                                       select m;
                foreach (var m in queryMaintenance)
                {
                    Maintenance = m;
                }
            }
            return Maintenance;
        }
        public static void DeleteByID(long MaintenanceID)
        {
            Maintenance Maintenance = new Maintenance();
            using (var db = new trafficEntities())
            {
                //finding Maintenance
                var queryMaintenance = from m in db.Maintenance
                                       where m.maintenanceID == MaintenanceID
                                       select m;
                Maintenance = queryMaintenance.First();
                db.Maintenance.Remove(Maintenance);
            }
        }

    }
}
