using Core.Services.Impl;
using Core.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Registries;

public static class ServiceRegistry
{
    public static void RegisterCoreServices(IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
    }
}