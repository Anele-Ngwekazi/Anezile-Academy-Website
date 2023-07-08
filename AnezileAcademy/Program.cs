

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace AnezileAcademy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateDefaultBuilder(args).Run();
        }

        public static IHost CreateDefaultBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .Build();
    }
}
