using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UserManagement.Service.Repository.Interface;
using UserManagement.Service.Services.Interface;
using UserManagement.Web.Areas.Administator.Controllers;
using Web.Areas.UserManagement.Dto;
using Web.Helpers;
using UserNs = UserManagement.Service.Services.Interface;

namespace Web.Areas.UserManagement.Controllers
{
    [Area("UserManagement")]
    [Route("UserManagement/account")]
    public class AccountController : BaseController
    {
        private readonly UserNs.AuthenticationService _authenticationService;
        private readonly UserLoggedInStatusRepository _loggedInUserStatusRepository;
        private readonly UserService _userService;
        private readonly OrganizationRepository _organizationRepository;

        public AccountController(UserNs.AuthenticationService authenticationService,UserLoggedInStatusRepository loggedInStatusRepository,UserService userService,OrganizationRepository organizationRepository)
        {
            _authenticationService = authenticationService;
            _loggedInUserStatusRepository = loggedInStatusRepository;
            _userService = userService;
            _organizationRepository = organizationRepository;
        }
        //private readonly AuthenticationService _authenticationService;
        //private readonly JwtFactory _jwtFactory;
        //private readonly UserService _userService;
        //private readonly UserRepository _userRepo;
        //private readonly UserLoggedInStatusRepository _userLogFlagRepo;
        //private readonly UserDetailRepository _userDetailRepo;
        //private readonly JwtTokenRepository _jwtTokenRepo;
        //private readonly JwtTokenService _jwtTokenService;

        //public AccountController(AuthenticationService authenticationService, JwtFactory jwtFactory, UserService userService, UserRepository userRepo, UserLoggedInStatusRepository userLogFlagRepo, JwtTokenRepository jwtTokenRepo, JwtTokenService jwtTokenService,UserDetailRepository userDetailRepo) : base()
        //{
        //    _jwtFactory = jwtFactory;
        //    _authenticationService = authenticationService;
        //    _userService = userService;
        //    _userRepo = userRepo;
        //    _userLogFlagRepo = userLogFlagRepo;
        //    _userDetailRepo = userDetailRepo;

        //    _jwtTokenRepo = jwtTokenRepo;
        //    _jwtTokenService = jwtTokenService;
       // }

        [Route("login")]
        [HttpGet]
        public IActionResult login()
        {
            ViewBag.organization = _organizationRepository.getAll().FirstOrDefault();
            return View();
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> login(LoginDto loginDto)
        {
            ViewBag.organization = _organizationRepository.getAll().FirstOrDefault();
            try
            {
                if (ModelState.IsValid)
                {
                    var authDetail = _authenticationService.validate(loginDto.username, loginDto.password);
                    if (authDetail == null)
                    {
                        throw new Exception("Username and Password didnot matched.");
                    }
                    if (!authDetail.is_active)
                        throw new Exception("This User is disabled. Please Contact Administrator");
                    if (!authDetail.is_email_confirmed)
                        throw new Exception("Email is not confirmed yet. Please confirm your email.");

                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier,authDetail.Id.ToString())
                        
                    };
                    var userIdentity = new ClaimsIdentity(claims, "local");

                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                    AuthenticationProperties prop = new AuthenticationProperties();
                    prop.ExpiresUtc = DateTime.UtcNow.AddDays(1);
                    prop.IsPersistent = loginDto.remember_me;
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, prop);

                   

                    return Redirect("/Administrator/Home");
                }

            }
            catch(Exception ex)
            {
                AlertHelper.setMessage(this, ex.Message, messageType.error);
            }
            return View(loginDto);
        }

        [Route("logout")]
        public async Task<IActionResult> logout()
        {
            await HttpContext.SignOutAsync();
            //@TODO keep logged in status
            return Redirect("/UserManagement/account/login");
        }

        //[HttpPost]
        //[Route("loginss")]
        //public IActionResult Post([FromBody]LoginDto dto)
        //{
        //    try
        //    {
        //        User user = new User();

        //        var newRefreshToken = GenerateRefreshToken();


        //            user = _authenticationService.validate(dto.username, dto.password);

        //            if (user == null)
        //            {
        //                throw new InvalidValueException("Username and Password didnot match.");
        //            }

        //            UserLoggedInStatus userLogDetail = _userLogFlagRepo.getById(user.Id);

        //            //if (userLogDetail != null && userLogDetail.IS_USER_ALREADY_LOGGED_IN)
        //            //{
        //            //    throw new InvalidStateTransitionException("User is already logged in.");
        //            //}

        //            if (userLogDetail == null)
        //            {
        //                userLogDetail = new UserLoggedInStatus();
        //                userLogDetail.user_id = user.Id;
        //                userLogDetail.setUserLoggedIn();

        //                _userLogFlagRepo.insert(userLogDetail);
        //            }
        //            else
        //            {
        //                userLogDetail.setUserLoggedIn();
        //                _userLogFlagRepo.update(userLogDetail);
        //            }
        //            _jwtTokenService.saveOrUpdate(user.Id, newRefreshToken, newRefreshToken);


        //        var userDetail = _userDetailRepo.getByUserId(user.Id) ?? new UserDetails();

        //        var tokenString = _jwtFactory.GenerateEncodedToken(userDetail, user).Result;

        //        var responseString = getTokenString(user, userDetail, tokenString, newRefreshToken);

        //        return Ok(responseString);
        //    }
        //    catch (CustomException ex)
        //    {
        //        return ApiResponse.getErrorResponseJson(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        return ApiResponse.getErrorResponseJson("Failed to authenticate user.");
        //    }
        //}

        //[HttpGet]
        //[Route("logout")]
        //public IActionResult LogOut()
        //{
        //    try
        //    {
        //        User user = new User();

        //            long loggedInUserId = getLoggedInUserId();
        //            var userLogDetail = _userLogFlagRepo.getById(loggedInUserId);

        //            if (userLogDetail != null)
        //            {
        //                userLogDetail.setUserLoggedOut();
        //                _userLogFlagRepo.update(userLogDetail);
        //            }


        //        return Ok();
        //    }
        //    catch (CustomException ex)
        //    {
        //        return ApiResponse.getErrorResponseJson(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        return ApiResponse.getErrorResponseJson("Failed to log user out of system.");
        //    }
        //}


        //[HttpPost]
        //[Route("register")]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "developerOrOwner")]
        //public IActionResult register([FromBody] RegisterDto dto)
        //{
        //    try
        //    {
        //        dto.created_by = getLoggedInUserId();
        //        dto.base_url = $"{Request.Scheme}://{Request.Host}";
        //        _userService.register(dto);
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return ApiResponse.getErrorResponseJson(ex.Message);
        //    }
        //}

        //[HttpGet]
        //[Route("confirm-email")]
        //public IActionResult markEmailAsRegistered([FromQuery] ConfirmRegistrationDto dto)
        //{
        //    try
        //    {
        //        _userService.markEmailRegistered(dto.token);
        //        return Ok();
        //    }
        //    catch (InvalidStateTransitionException ex)
        //    {
        //        return new JsonResult(new { success = false, responseText = ex.Message, statusCode = 100 });
        //    }
        //    catch (Exception ex)
        //    {
        //        return ApiResponse.getErrorResponseJson(ex.Message);
        //    }
        //}

        //[HttpPost("refresh-token")]
        //public ActionResult RefreshToken([FromBody] RefreshTokenDto data)
        //{
        //    try
        //    {
        //        var principal = _jwtFactory.GetPrincipalFromExpiredToken(data.jwt_token);

        //        long userId = Convert.ToInt64(principal.FindFirst("id")?.Value);

        //        var newJwtToken = _jwtFactory.GenerateToken(principal.Claims.ToList());
        //        bool isUserDeveloper = userId == 0;

        //        string newRefreshToken = "";
        //        if (!isUserDeveloper)
        //        {
        //            List<JwtToken> savedRefreshTokenOfUser = getRefreshTokensOfUser(userId);

        //            JwtToken tokenWithOldRefreshToken = savedRefreshTokenOfUser.Where(a => a.old_token == data.refresh_token).SingleOrDefault() ?? throw new InvalidValueException("Refresh token is not valid");

        //            if (string.IsNullOrWhiteSpace(tokenWithOldRefreshToken.new_token))
        //            {
        //                newRefreshToken = GenerateRefreshToken();
        //                _jwtTokenService.saveOrUpdate(userId, data.refresh_token, newRefreshToken);
        //            }
        //            else
        //            {
        //                newRefreshToken = tokenWithOldRefreshToken.new_token;
        //            }
        //        }

        //        var user = _userRepo.getById(userId) ?? new User();

        //        var userDetail = _userDetailRepo.getByUserId(userId) ?? new UserDetails();

        //        bool isSuperAdmin = User.FindFirst(UserTypeClaims.userTypeClaimKey)?.Value == UserTypeClaims.developerClaim;

        //        var responseString = getTokenString(user, userDetail, newJwtToken, newRefreshToken);

        //        return Ok(responseString);
        //    }
        //    catch (CustomException ex)
        //    {
        //        return ApiResponse.getErrorResponseJson(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        return ApiResponse.getErrorResponseJson("Failed to refresh token.");
        //    }
        //}

        //private string GenerateRefreshToken()
        //{
        //    var randomNumber = new byte[32];
        //    using (var rng = RandomNumberGenerator.Create())
        //    {
        //        rng.GetBytes(randomNumber);
        //        return Convert.ToBase64String(randomNumber);
        //    }
        //}
        //private List<JwtToken> getRefreshTokensOfUser(long user_id)
        //{
        //    var tokenDetails = _jwtTokenRepo.getByUserId(user_id);
        //    return tokenDetails;
        //}

        //private object getTokenString(User user, UserDetails user_detail, string tokenString, string new_refresh_token)
        //{
        //    var userRoleName = string.Empty;
        //    var userRole = user.user_role_maps;
        //    if (userRole.Count() > 0)
        //        userRoleName = String.Join(',', userRole.Select(a => a.Role.name));

        //    string imagePath = $"assets/images/{user_detail.image}";

        //    return new
        //    {
        //        user_id = user.Id,
        //        full_name = user_detail.first_name,
        //        email = user.email,
        //        is_active = user.is_active,
        //        address_line_1 = user_detail.permanent_address,
        //        address_line_2 = user_detail.temporary_address,
        //        created_by = user_detail.created_by,
        //        created_date = user_detail.created_date,
        //        primary_contact = user_detail.primary_contact,
        //        secondary_contact = user_detail.secondary_contact,
        //        ROLE_NAME = userRoleName,

        //        token = tokenString,
        //        allowed_urls = getAllowedMenuUrls(user),
        //        image_path = imagePath,
        //        user.password_change_count,
        //        refresh_token = new_refresh_token
        //    };
        //}

        //private List<string> getAllowedMenuUrls(User user)
        //{
        //    if (user.Id == 0)
        //    {
        //        var menus = _dynamicMenuRepo.getQueryable().Where(a => !a.is_deleted).Select(a => a.web_url).ToList();
        //        return menus;
        //    }

        //    return _dynamicMenuRepo.getMenusAssignedToUser(user.Id).Select(a => a.web_url).ToList();
        //}

        //[HttpPut]
        //[Route("recover-password")]
        //public IActionResult recoverPassword([FromBody]RecoverPasswordDto dto)
        //{
        //    try
        //    {
        //        dto.base_url = $"{Request.Scheme}://{Request.Host}";
        //        _userService.sendPasswordRecoveryEmail(dto);
        //        return Ok();
        //    }
        //    catch (CustomException ex)
        //    {
        //        return ApiResponse.getErrorResponseJson(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        return ApiResponse.getErrorResponseJson("Failed to recover password.");
        //    }
        //}

        //[HttpPut]
        //[Route("reset-password")]
        //public IActionResult resetPassword([FromBody]ChangePasswordDto dto)
        //{
        //    try
        //    {
        //        _userService.resetPassword(dto);
        //        return Ok();
        //    }
        //    catch (CustomException ex)
        //    {
        //        return ApiResponse.getErrorResponseJson(ex.Message);
        //    }
        //    catch (Exception)
        //    {
        //        return ApiResponse.getErrorResponseJson("Failed to change password.");
        //    }
        //}
    }
}
