using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


namespace LifeSpot
{
    public class Program
    {

        public static void Main(string[] args)
        {
            // Выводим информационное сообщение
            Logger.PrintMessage((() => Logger.Info("Запускаем приложение")));

            CreateHostBuilder(args).Build().Run();
        }

        private static void Target(string str)
        {
            throw new NotImplementedException();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}