using Dychar.Dyframe.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Dychar.Dyframe.Permissions
{
    public class DyframePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(DyframePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(DyframePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<DyframeResource>(name);
        }
    }
}
