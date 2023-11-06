using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


namespace LifeSpot
{
    public class Program
    {

        public static void Main(string[] args)
        {
            // ������� �������������� ���������
            Logger.PrintMessage((() => Logger.Info("��������� ����������")));

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