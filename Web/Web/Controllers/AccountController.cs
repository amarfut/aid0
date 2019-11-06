using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignInGoogle()
        {
            return Challenge(new AuthenticationProperties()
            {
                RedirectUri = Url.Action(nameof(LoginCallback))
                
            },
            "Google");
        }

        //[Authorize(AuthenticationSchemes = "Github")]
        public IActionResult SignInGithub()
        {
            return Challenge(new AuthenticationProperties()
            {
                RedirectUri = Url.Action(nameof(LoginCallback))

            },
            "Github");
        }


        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Home/Index");
        }

        public async Task<IActionResult> LoginCallback(object c)
        {
            var type = HttpContext.User.Identity.AuthenticationType;

            var authenticateResult = await HttpContext.AuthenticateAsync(type);

            

            if (!authenticateResult.Succeeded)
                return BadRequest(); // TODO: Handle this better.

            var claimsIdentity = new ClaimsIdentity("Application");

            claimsIdentity.AddClaim(authenticateResult.Principal.FindFirst(ClaimTypes.NameIdentifier));
            claimsIdentity.AddClaim(authenticateResult.Principal.FindFirst(ClaimTypes.Email));

            await HttpContext.SignInAsync("Cookies", new ClaimsPrincipal(claimsIdentity));

            return Redirect("/");
        }
    }
}