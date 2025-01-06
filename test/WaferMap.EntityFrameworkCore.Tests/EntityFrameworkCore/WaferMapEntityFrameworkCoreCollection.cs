using Xunit;

namespace WaferMap.EntityFrameworkCore;

[CollectionDefinition(WaferMapTestConsts.CollectionDefinitionName)]
public class WaferMapEntityFrameworkCoreCollection : ICollectionFixture<WaferMapEntityFrameworkCoreFixture>
{

}
