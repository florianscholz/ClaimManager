using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ClaimManager.Authentication
{
    public interface IAuthenticationService
    {
        public Task SignIn(HttpContext httpContext, string username);
    }
}