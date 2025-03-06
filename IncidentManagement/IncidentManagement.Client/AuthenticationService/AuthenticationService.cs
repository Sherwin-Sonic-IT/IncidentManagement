using Microsoft.AspNetCore.Components.Authorization;
using SharedLibrary.AuthenticationInterface;
using System.Security.Claims;

public class AuthenticationService : IAuthenticationInterface
{
    private readonly AuthenticationStateProvider _authenticationStateProvider;

    public AuthenticationService(AuthenticationStateProvider authenticationStateProvider)
    {
        _authenticationStateProvider = authenticationStateProvider;
    }

    public async Task<(int UserId, string UserName, string UserRole, bool IsAdmin, string Location)> AuthenticateUser()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        var userIdClaim = user?.FindFirst(ClaimTypes.PrimarySid)?.Value;
        int userId = userIdClaim != null ? int.Parse(userIdClaim) : 0;

        string userName = user.Identity?.Name ?? string.Empty;

        var roleClaim = user?.FindFirst(ClaimTypes.Role)?.Value ?? "No role assigned";
        bool isAdmin = roleClaim.Equals("SysAdmin", StringComparison.OrdinalIgnoreCase);

        string location = user?.FindFirst("Location")?.Value ?? "Unknown"; 

        return (userId, userName, roleClaim, isAdmin, location);
    }

}
