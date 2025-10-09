using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using GeometriaDesktop;
using GeometriaModels.DALs;
using GeometriaModels.Services;

//host es el contenedor principal de la aplicación.
var host = Host.CreateDefaultBuilder()
.ConfigureServices((context, services) =>
{
    #region Registro de DALs
    services.AddSingleton<IBaseDAL, ListFigurasDal>();
    #endregion

    #region Registro de services.
    services.AddSingleton <FiguraService>();
    #endregion


    #region Registro de las vistas
    services.AddTransient<Form1>();
    #endregion
})
.Build();

ApplicationConfiguration.Initialize();
var form = host.Services.GetRequiredService<Form1>();
Application.Run(form);