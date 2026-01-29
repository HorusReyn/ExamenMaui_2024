using System.Configuration;

namespace EindExamenMaui
{
    public static class DatabaseConnection
    {
        public static string Connectionstring(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
