using AuctionSim.Infrastructure.Auctions;
using AuctionSim.Infrastructure.Databases;
using Domain.Auctions.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AuctionSim.Infrastructure;

public static class InfrastructureDependencyInjection
{
    public static IServiceCollection AddInfrasctureServices(this IServiceCollection services)
    {
        services.AddDbContext<AuctionSimDbContext>((sp, opt) => opt.UseSqlite(
                @"Data Source=/home/eduardo/dev/study/csharp/AuctionSim/leilaoDbNLW.db",
                x => x.MigrationsAssembly(typeof(AuctionSimDbContext).Assembly.GetName().Name)));
            
        services.AddScoped<IAuctionRepository, AuctionRepository>();

        return services;
    }
}
