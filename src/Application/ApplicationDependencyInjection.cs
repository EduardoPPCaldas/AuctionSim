using AuctionSim.Application.Auctions;
using Microsoft.Extensions.DependencyInjection;

namespace AuctionSim.Application;

public static class ApplicationDependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IGetCurrentAuctionUseCase, GetCurrentAuctionUseCase>();

        return services;
    }
}
