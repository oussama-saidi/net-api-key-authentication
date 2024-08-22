using Microsoft.AspNetCore.Mvc;

namespace WebApi.keyAuthentication.Demo.Authentication;

public class ApiKeyAttribute : ServiceFilterAttribute
{
    public ApiKeyAttribute()
        : base(typeof(ApiKeyAuthorizationFilter))
    {
    }
}