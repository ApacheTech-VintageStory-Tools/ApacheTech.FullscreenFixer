using System.Security.Principal;

namespace ApacheTech.FullscreenFixer.Extensions
{
    public static class UserEx
    {
        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);

        }
    }
}