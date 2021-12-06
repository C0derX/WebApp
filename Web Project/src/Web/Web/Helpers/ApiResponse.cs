using Microsoft.AspNetCore.Mvc;

namespace Web.Helpers
{
    public class ApiResponse
    {
        public static BadRequestObjectResult getErrorResponseJson(string message)
        {
            return new BadRequestObjectResult(new { success = false, responseText = message });
        }
    }
}
