using WaferMap.EntityFrameworkCore;
using Xunit;

namespace WaferMap;

[CollectionDefinition(WaferMapTestConsts.CollectionDefinitionName)]
public class WaferMapDomainCollection : WaferMapEntityFrameworkCoreCollectionFixtureBase
{

}
