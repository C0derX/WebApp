using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Web.Areas.UserManagement.Auth;
using Web.Areas.UserManagement.Models;
using Newtonsoft.Json;
using UserManagement.Entities;

namespace Web.Areas.UserManagement.Helpers
{
    public class Tokens
    {
        public static async Task<string> GenerateJwt(UserDetails user_detail, JwtFactory jwtFactory, User user, JwtIssuerOptions jwtOptions, JsonSerializerSettings serializerSettings)
        {
            var response = new
            {
                id = user.Id,
                auth_token = await jwtFactory.GenerateEncodedToken(user_detail, user),
                expires_in = (int)jwtOptions.ValidFor.TotalSeconds
            };

            return JsonConvert.SerializeObject(response, serializerSettings);
        }
    }
}
