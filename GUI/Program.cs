using Domain.Services;
using Interfaces.Services;
using System.Globalization;
using System.ServiceProcess;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Thread.CurrentThread.CurrentCulture = new CultureInfo("dk-DK");

            ApplicationConfiguration.Initialize();

            IDomainServiceManager ServiceManager = new DomainServiceManager();

            Application.Run(new Login(ServiceManager));
        }
    }
}