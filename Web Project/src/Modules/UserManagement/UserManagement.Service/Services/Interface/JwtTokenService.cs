namespace UserManagement.Service.Services.Interface
{
    public interface JwtTokenService
    {
        void saveOrUpdate(long user_id, string previous_refresh_token, string new_refresh_token);
    }
}
