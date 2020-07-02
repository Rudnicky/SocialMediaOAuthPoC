using System;

namespace SocialMediaOAuthPoC.Services
{
    public interface IFacebookLoginService
    {
        string AccessToken { get; }
        Action<string, string> AccessTokenChanged { get; set; }
        void Logout();
    }
}
