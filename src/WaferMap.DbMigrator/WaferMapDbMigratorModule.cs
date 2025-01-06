using WaferMap.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace WaferMap.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(WaferMapEntityFrameworkCoreModule),
    typeof(WaferMapApplicationContractsModule)
    )]
public class WaferMapDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
