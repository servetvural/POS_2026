using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TestWcfService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1 {

        //private string connStr = "Data Source =80.101.86.198; Initial Catalog=DTRMSimple; uid=sa; pwd=servetvural;";
        private string connStr = "Data Source =192.168.2.2; Initial Catalog=DTRMSimple; uid=sa; pwd=servetvural;";

        private SqlConnection GetOpenSqlConnection() {
            SqlConnection connection = new SqlConnection(connStr);
            connection.Open();
            return connection;
        }

        public List<EntityName> GetEntityNames() {
            List<EntityName> entityList = new List<EntityName>();
            SqlConnection connection = new SqlConnection(connStr);
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select EntityName from Entity", connection);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read()) {
                EntityName entity = new EntityName();
                entity.Entity = sdr["EntityName"].ToString();
                entityList.Add(entity);

            }
            return entityList.ToList();
           
        }

        public float GetSessionTotal() {
            SqlCommand cmd = new SqlCommand("Select GrossSessionTotal from SessionSum", GetOpenSqlConnection());
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read()) {
                return float.Parse(sdr["GrossSessionTotal"].ToString());
                
            }
            return 0;
        }


        //public string GetData(int value) {
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite) {
        //    if (composite == null) {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue) {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
    }
}
