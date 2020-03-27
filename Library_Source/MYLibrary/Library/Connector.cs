using Library.DataAccess;
using System.Collections.Generic;
using System.Configuration;
namespace Library
{
   public static class Connector
    {
        public static List<IConnection> connections { get; private set; } = new List<IConnection>();
        public static void Initialize(bool sql,bool text)
        {
            if (sql)
            {
                SqlConnector sqlconnection = new SqlConnector();
                connections.Add(sqlconnection);
            }
            if (text)
            {
                TextConnector textconnection = new TextConnector();
                //connections.Add(textconnection);
            }
        }
        public static string CnnString(string conName)
        {
            if (conName == "Library")
            {
                //return @"Server=DESKTOP-EE7L8AI\ELSAYEDHAMDY;Database=Library;Trusted_Connection=True;MultipleActiveResultSets=True;";
                //return @"Server=(LocalDB)\MSSQLLocalDB;Database=Library;Trusted_Connection=True";
                return ConfigurationManager.ConnectionStrings[conName].ConnectionString;
            }
            else
            {
            //return @"Server=DESKTOP-EE7L8AI\ELSAYEDHAMDY;Database=master;Trusted_Connection=True;MultipleActiveResultSets=True;";
            //return @"Server=(LocalDB)\MSSQLLocalDB;Database=Library;Trusted_Connection=True";
            return ConfigurationManager.ConnectionStrings["master"].ConnectionString;
            }
        }
    }
}
