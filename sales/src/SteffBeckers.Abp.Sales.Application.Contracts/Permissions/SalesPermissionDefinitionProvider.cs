using SteffBeckers.Abp.Sales.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace SteffBeckers.Abp.Sales.Permissions
{
    public class SalesPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var salesGroup = context.AddGroup(SalesPermissions.GroupName, L("Permission:Sales"));

            // Accounts
            PermissionDefinition accountsPermission = salesGroup.AddPermission(SalesPermissions.Accounts, L("Permission:Accounts"), MultiTenancySides.Both);
            accountsPermission.AddChild(SalesPermissions.CreateAccounts, L("Permission:Accounts:Create"), MultiTenancySides.Both);
            accountsPermission.AddChild(SalesPermissions.EditAccounts, L("Permission:Accounts:Edit"), MultiTenancySides.Both);
            accountsPermission.AddChild(SalesPermissions.DeleteAccounts, L("Permission:Accounts:Delete"), MultiTenancySides.Both);
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SalesResource>(name);
        }
    }
}