using Microsoft.Extensions.Configuration;
using System.IO;

namespace Lou.Data
{
    public class DataAccess
    {
        public static string ConnectionString
        {
            get
            {
                var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appSettings.json");
                var config = builder.Build();
                return "User ID=sa;Password=123456;server=localhost;Database=Test;Pooling=true;";
            }
        }

    }
}
