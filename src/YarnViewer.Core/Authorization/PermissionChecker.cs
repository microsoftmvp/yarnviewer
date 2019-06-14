using Abp.Authorization;
using YarnViewer.Authorization.Roles;
using YarnViewer.Authorization.Users;

namespace YarnViewer.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
