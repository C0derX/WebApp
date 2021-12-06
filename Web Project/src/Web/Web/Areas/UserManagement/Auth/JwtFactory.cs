
using UserManagement.Entities;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Web.Areas.UserManagement.Auth
{
    public interface JwtFactory
    {
        Task<string> GenerateEncodedToken(UserDetails user_detail, User user);
        ClaimsIdentity GenerateClaimsIdentity(string userName, string id);
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);

        string GenerateToken(List<Claim> claims);
    }
}
