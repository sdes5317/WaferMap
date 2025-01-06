using System.Threading.Tasks;

namespace WaferMap.Data;

public interface IWaferMapDbSchemaMigrator
{
    Task MigrateAsync();
}
