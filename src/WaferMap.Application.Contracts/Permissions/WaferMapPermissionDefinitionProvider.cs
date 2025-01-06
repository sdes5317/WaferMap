using WaferMap.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace WaferMap.Permissions;

public class WaferMapPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(WaferMapPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(WaferMapPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<WaferMapResource>(name);
    }
}
