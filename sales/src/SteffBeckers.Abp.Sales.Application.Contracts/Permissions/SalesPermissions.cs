using Volo.Abp.Reflection;

namespace SteffBeckers.Abp.Sales.Permissions
{
    public class SalesPermissions
    {
        public const string GroupName = "Sales";

        // Accounts
        public const string Accounts = GroupName + ".Accounts";
        public const string CreateAccounts = Accounts + ".Create";
        public const string EditAccounts = Accounts + ".Update";
        public const string DeleteAccounts = Accounts + ".Delete";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(SalesPermissions));
        }
    }
}