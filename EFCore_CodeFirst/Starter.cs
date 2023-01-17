using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace EFCore_CodeFirst
{
    internal class Starter
    {
        public static void Run()
        {
            var options = GetDbOptions();

            using (var db = new ApplicationContext(options))
            {
                // ...
            }
        }

        private static DbContextOptions<ApplicationContext> GetDbOptions()
        {
            string jsonSettingsFile = "appsettings.json";

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile(jsonSettingsFile);

            var config = builder.Build();
            string? connectionString = config.GetConnectionString("DefaultConnection");

            if (connectionString is null)
            {
                throw new Exception("connection string is null");
            }

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder.UseSqlServer(connectionString).Options;

            return options;
        }
    }
}
