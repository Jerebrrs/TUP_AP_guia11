using GeometriaModels.DALs;
using GeometriaModels.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GeometriaDesktop
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

            var host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.AddSingleton<IBaseDAL, ListFigurasDal>();
                services.AddSingleton<FiguraService>();
                services.AddTransient<Form1>();
            }).Build();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}