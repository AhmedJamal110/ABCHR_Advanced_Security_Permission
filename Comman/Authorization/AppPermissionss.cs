
using System.Collections.ObjectModel;

namespace Comman.Authorization
{
    public class AppPermissionss
    {
        private static readonly AppPermission[] _All =
        [
            new(AppFeature.Users, AppAction.Create, AppRoleGroup.SystemAccess , "Create User"),
            new(AppFeature.Users, AppAction.Update, AppRoleGroup.SystemAccess , "Update User"),
            new(AppFeature.Users, AppAction.Delete, AppRoleGroup.SystemAccess , "Delete User"),
            new(AppFeature.Users, AppAction.Read, AppRoleGroup.SystemAccess , "Read User"),

            new(AppFeature.UserRoles, AppAction.Update, AppRoleGroup.SystemAccess , "Update User Roles"),
            new(AppFeature.UserRoles, AppAction.Read, AppRoleGroup.SystemAccess , "Read User Roles"),

            new(AppFeature.Roles, AppAction.Create, AppRoleGroup.SystemAccess , "Create Roles"),
            new(AppFeature.Roles, AppAction.Update, AppRoleGroup.SystemAccess , "Update Roles"),
            new(AppFeature.Roles, AppAction.Delete, AppRoleGroup.SystemAccess , "Delete Roles"),
            new(AppFeature.Roles, AppAction.Read, AppRoleGroup.SystemAccess , "Read Roles"),


            new(AppFeature.RoleClaims, AppAction.Update, AppRoleGroup.SystemAccess , "Update Roles/Claims"),
            new(AppFeature.RoleClaims, AppAction.Read, AppRoleGroup.SystemAccess , "Read Roles/Claims"),


             new(AppFeature.Employees, AppAction.Create, AppRoleGroup. ManagmentHierarchy, "Create Employees"),
            new(AppFeature.Employees, AppAction.Update, AppRoleGroup.ManagmentHierarchy , "Update Employees"),
            new(AppFeature.Employees, AppAction.Delete, AppRoleGroup.ManagmentHierarchy , "Delete Employees"),
            new(AppFeature.Employees, AppAction.Read, AppRoleGroup.ManagmentHierarchy , "Read Employess" , true),

        ];

        public static IReadOnlyList<AppPermission> AdminPermission { get; }
        = new ReadOnlyCollection<AppPermission>
            (_All.Where(x => !x.IsBasic).ToList());


        public static IReadOnlyList<AppPermission> BasicPermission { get; }
        = new ReadOnlyCollection<AppPermission>
            (_All.Where(x => x.IsBasic).ToList());
    }
}
