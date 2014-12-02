using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
namespace Traffic
{
    public class EmployeeLogic
    {
        public static List<Employee> ReadAll()
        {
            List<Employee> AllItems = new List<Employee>();
            using (var db = new trafficEntities())
            {
                var query = from o in db.Employee
                            orderby o.organizationID
                            select o;
                foreach (var org in query)
                {
                    AllItems.Add(org);
                }
            }
            return (AllItems);
        }
        public static void Add(long addressID, long organizationID, string tableNumber, string FirstName, string LastName, string ParentName, DateTime BirthDay, string IDnumber, string PassportSerie, string PassportNumber, DateTime DatePassportUntil, DateTime DatePassportFrom, string position)
        {
            var Item = new Employee
            {
                addressID = addressID,
                organizationID = organizationID,
                tableNumber = tableNumber,
                FirstName = FirstName,
                LastName = LastName,
                ParentName=ParentName,
                BirthDay=BirthDay,
                IDnumber=IDnumber,
                PassportSerie=PassportSerie,
                PassportNumber=PassportNumber,
                DatePassportUntil=DatePassportUntil,
                DatePassportFrom=DatePassportFrom,
                position = position
                
            };
            using (var db = new trafficEntities())
            {
                db.Employee.Add(Item);
                db.SaveChanges();
            }
        }
        public static void Edit(long addressID, long organizationID, string tableNumber, string FirstName, string LastName, string ParentName, DateTime BirthDay, string IDnumber, string PassportSerie, string PassportNumber, DateTime DatePassportUntil, DateTime DatePassportFrom, string position)
        {
            using (var db = new trafficEntities())
            {
                var queryOrg = from o in db.Employee
                               where o.tableNumber == tableNumber
                               select o;
                Employee updateItem = queryOrg.First();
                updateItem.addressID = addressID;
                updateItem.organizationID = organizationID;
                updateItem.tableNumber = tableNumber;
                updateItem.FirstName = FirstName;
                updateItem.LastName = LastName;
                updateItem.ParentName=ParentName;
                updateItem.BirthDay=BirthDay;
                updateItem.IDnumber=IDnumber;
                updateItem.PassportSerie=PassportSerie;
                updateItem.PassportNumber=PassportNumber;
                updateItem.DatePassportUntil=DatePassportUntil;
                updateItem.DatePassportFrom=DatePassportFrom;
                updateItem.position = position;
                db.SaveChanges();
            }
        }

        public static void DeleteByID(long addressID)
        {
            using (var db = new trafficEntities())
            {
                var queryOrg = from o in db.Employee
                               where o.addressID == addressID
                               select o;
                Employee deleteteItem = queryOrg.First();
                db.Employee.Remove(deleteteItem);
                db.SaveChanges();
            }
        }

        public static List<Employee> GetFilteredUsersInfo(string filterString)
        {
            List<Employee> retList = new List<Employee>();

            string sqlQuery = string.Format("select * from Users where LastName like '%{0}%'", filterString);

            SqlConnection _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            _conn.Open();

            using (SqlCommand cmd = new SqlCommand(sqlQuery, _conn))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    retList.Add(new Employee
                    {
                        addressID = (long)dr["addressID"],
                        organizationID = (long)dr["organizationID"],
                        tableNumber = (string)dr["tableNumber"],
                        FirstName = (string)dr["FirstName"],
                        LastName = (string)dr["LastName"],
                        ParentName = (string)dr["ParentName"],
                        BirthDay = (DateTime)dr["BirthDay"],
                        IDnumber = (string)dr["IDnumber"],
                        PassportSerie = (string)dr["PassportSerie"],
                        PassportNumber = (string)dr["PassportNumber"],
                        DatePassportUntil = (DateTime)dr["DatePassportUntil"],
                        DatePassportFrom = (DateTime)dr["DatePassportFrom"],
                        position = (string)dr["position"]
                    });
                }
                dr.Close();
            }

            _conn.Close();

            return retList;
        }

    }
}
