using Volo.Abp.Settings;

namespace WaferMap.Settings;

public class WaferMapSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(WaferMapSettings.MySetting1));
    }
}
