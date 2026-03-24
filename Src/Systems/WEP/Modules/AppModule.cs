using WepAPI.Src.WEP.Database;
using WepAPI.Src.WEP.Modules.UnitOfWork;
using WepAPI.Src.WEP.Modules.Users;

namespace WepAPI.Src;

/// <summary>
/// Modulo que registra todos los servicios de todos los modulos.
/// </summary>
public static class AppModule
{
    public static IServiceCollection AddAppModules(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services
            .DatabaseModule(configuration) 
            .UserModule()
            .AddUnitOfWork();
        return services;
    }
}