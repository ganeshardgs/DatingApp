using System.Security.Claims;

namespace API.Extensions;

public static class ClaimsPrincipleExtensions
{
    public static string GetMemberId(this ClaimsPrincipal user)
    {
       return user.FindFirstValue(ClaimTypes.NameIdentifier) ??
        throw new InvalidOperationException("Member ID not found in claims.");
    }
}
