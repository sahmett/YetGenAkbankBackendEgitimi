using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace RentCar.Persistence
{
    public static class Configuration
    {
        public static string GetString(string key)
        {
            ConfigurationManager configurationManager = new();

            string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName}" + //ana klasör 6 seviyesi
                $"\\Infrastructor\\RentCar.Persistence\\";

            configurationManager.SetBasePath(path);
            configurationManager.AddJsonFile("PrivateInformation.json");

            return configurationManager.GetSection(key).Value; //altına girmek için : kullanılır
        }
    }
}




