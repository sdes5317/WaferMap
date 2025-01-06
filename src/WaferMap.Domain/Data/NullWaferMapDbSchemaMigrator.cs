using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace WaferMap.Data;

/* This is used if database provider does't define
 * IWaferMapDbSchemaMigrator implementation.
 */
public class NullWaferMapDbSchemaMigrator : IWaferMapDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
