using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Entities;
using Web.Areas.UserManagement.Models;

namespace Web.Areas.UserManagement.Auth
{
    public class JwtFactoryImpl : JwtFactory
    {
        private readonly JwtIssuerOptions _jwtOptions;
        private readonly AuthSettings _authSettings;

        public JwtFactoryImpl(IOptions<JwtIssuerOptions> jwtOptions, IOptions<AuthSettings> authSettings)
        {
            _jwtOptions = jwtOptions.Value;
            _authSettings = authSettings.Value;
            ThrowIfInvalidOptions(_jwtOptions);
        }

        public async Task<string> GenerateEncodedToken(UserDetails user_detail, User user)
        {

            //add employee_id if employee

            var userType = "normalUser";
            string email = "admin@test.com";
            string userId = "0";

            //if (!is_super_admin)
            //{
            //    email = user.EMAIL;
            //    userId = user.ID.ToString();
            //    organisationId = user.ORGANISATION_ID.ToString();
            //}

            //if (user.IS_OWNER)
            //{
            //    userType = UserTypeClaims.organisationAdminUserClaim;
            //}
            //else if (is_super_admin)
            //{
            //    userType = UserTypeClaims.developerClaim;
            //}

            var claims = new List<Claim>
                  {
              new Claim(JwtRegisteredClaimNames.Sub, email),
              new Claim(JwtRegisteredClaimNames.Jti, await _jwtOptions.JtiGenerator()),

              new Claim(JwtRegisteredClaimNames.Iat, ToUnixEpochDate(_jwtOptions.IssuedAt).ToString(),
                                      ClaimValueTypes.Integer64),
              new Claim("id", userId),
              //new Claim("organisation_id",organisationId),
              //  new Claim("employee_id",employeeId.ToString())
                   };
            claims.Add(new Claim(UserTypeClaims.normalUserClaim, userType));



            var encodedJwt = GenerateToken(claims);

            return encodedJwt;
        }

        public string GenerateToken(List<Claim> claims)
        {
            var jwt = new JwtSecurityToken(
               issuer: _jwtOptions.Issuer,
               audience: _jwtOptions.Audience,
               claims: claims,
               notBefore: _jwtOptions.NotBefore,
               expires: _jwtOptions.Expiration,
               signingCredentials: _jwtOptions.SigningCredentials);

            return new JwtSecurityTokenHandler().WriteToken(jwt); //the method is called WriteToken but returns a string
        }

        public ClaimsIdentity GenerateClaimsIdentity(string userName, string id)
        {
            return new ClaimsIdentity(new GenericIdentity(userName, "Token"), new[]
            {
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.Id, id),
                new Claim(Helpers.Constants.Strings.JwtClaimIdentifiers.Rol, Helpers.Constants.Strings.JwtClaims.ApiAccess)
            });
        }

        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = false, //you might want to validate the audience and issuer depending on your use case
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authSettings.SecretKey)),
                ValidateLifetime = false
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                throw new SecurityTokenException("Invalid token");

            return principal;
        }

        /// <returns>Date converted to seconds since Unix epoch (Jan 1, 1970, midnight UTC).</returns>
        private static long ToUnixEpochDate(DateTime date)
          => (long)Math.Round((date.ToUniversalTime() -
                               new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero))
                              .TotalSeconds);

        private static void ThrowIfInvalidOptions(JwtIssuerOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            if (options.ValidFor <= TimeSpan.Zero)
            {
                throw new ArgumentException("Must be a non-zero TimeSpan.", nameof(JwtIssuerOptions.ValidFor));
            }

            if (options.SigningCredentials == null)
            {
                throw new ArgumentNullException(nameof(JwtIssuerOptions.SigningCredentials));
            }

            if (options.JtiGenerator == null)
            {
                throw new ArgumentNullException(nameof(JwtIssuerOptions.JtiGenerator));
            }
        }
    }
}
