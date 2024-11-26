
namespace Comman.Authorization
{
    public record AppPermission
        (
         string Feature 
        ,string Action
        ,string Group
        ,string Description
        ,bool IsBasic = false
        )
    {
        public string Name { get; set; } = string.Empty;

        public static string MethodNameFor(string feature , string action )
        {
            return $"Permissoon.{feature}.{action}";
        }
    }
}
