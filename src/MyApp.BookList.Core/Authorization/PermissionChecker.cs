using Abp.Authorization;
using MyApp.BookList.Authorization.Roles;
using MyApp.BookList.Authorization.Users;

namespace MyApp.BookList.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
