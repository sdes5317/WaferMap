using WaferMap.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace WaferMap;

[DependsOn(
    typeof(WaferMapEntityFrameworkCoreTestModule)
    )]
public class WaferMapDomainTestModule : AbpModule
{

}
