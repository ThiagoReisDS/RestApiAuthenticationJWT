using System.Collections.Generic;
using System.Security.Claims;

namespace RestApiAuthenticationJwt.Services
{
    public interface ITokenService
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal getPrincipalFromExpiredToken(string token);
    }
}
