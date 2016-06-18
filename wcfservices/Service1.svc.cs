using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;


namespace wcfservices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

    public class Service1 : IService1
    {
        
        public void storeData(string name, string email)
        {
            //string connectionString = "Server=tcp:hari123.database.windows.net,1433;Data Source=hari123.database.windows.net;Initial Catalog=hari1234;Persist Security Info=False;User ID={your_username};Password={your_password};Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string connectionString = "Server=tcp:hari123.database.windows.net,1433;Data Source=hari123.database.windows.net;Initial Catalog=hari123;Persist Security Info=False;User ID={saihari.adabala};Password={0!@@###Aa};Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand com = new SqlCommand();
            com.CommandText = "insert into Table1 values('" + name + "','" + email + "')";
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
