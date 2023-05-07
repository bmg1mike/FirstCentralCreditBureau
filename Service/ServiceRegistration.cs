using Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;
using Service.Implementation;

namespace Service;

public static class ServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddHttpClient<IBaseService, BaseService>();
        services.AddScoped<IBaseService, BaseService>();
        services.AddScoped<IFirstCentralCreditBureauService, FirstCentralCreditBureauService>();
        return services;
    }
}