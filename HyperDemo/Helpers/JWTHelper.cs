using JWT.Algorithms;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HyperDemo.Helpers
{
    public static class JWTHelper
    {

        private const string SHARED_SECRET = "hackathon2019_secret";

        public static string GenerateJWT()
        {
            var userId = HttpContext.Current.User.Identity.GetUserId();
            var manager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var currentUser = manager.FindById(userId);

            return new JWT.Builder.JwtBuilder()
                    .WithAlgorithm(new HMACSHA256Algorithm())
                    .WithSecret(SHARED_SECRET)
                    .AddClaim("iss", "hyperdemo_hackathon")
                    .AddClaim("sub", currentUser.Id)
                    .AddClaim("email", currentUser.Email)
                    .AddClaim("exp", DateTimeOffset.UtcNow.AddSeconds(10).ToUnixTimeSeconds())
                    .Build();
        }
    }
}