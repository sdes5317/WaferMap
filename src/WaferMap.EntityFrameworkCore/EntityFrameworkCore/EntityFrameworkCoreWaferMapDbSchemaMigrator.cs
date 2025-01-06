using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WaferMap.Data;
using Volo.Abp.DependencyInjection;

namespace WaferMap.EntityFrameworkCore;

public class EntityFrameworkCoreWaferMapDbSchemaMigrator
    : IWaferMapDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreWaferMapDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the WaferMapDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<WaferMapDbContext>()
            .Database
            .MigrateAsync();
    }
}
