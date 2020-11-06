namespace Manifest
{
    public class DataAccess
    {
        public static string GetConnectionString(string _id= "Sqlite")
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[_id].ConnectionString;
        }
        
    }
}
