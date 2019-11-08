﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.AppServices;
using Services.DTOs;
using Services.Utils;

namespace Web.Controllers
{
    public class AccountController : BaseController
    {
        private UserService _userService = new UserService();

        public IActionResult SignInExternal(string externalProvider)
        {
            return Challenge(new AuthenticationProperties()
            {
                RedirectUri = Url.Action(nameof(LoginCallback))
            },
            externalProvider);
        }

        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Home/Index");
        }

        public async Task<IActionResult> LoginCallback()
        {
            var type = HttpContext.User.Identity.AuthenticationType;
            var authenticateResult = await HttpContext.AuthenticateAsync(type);

            if (!authenticateResult.Succeeded)
                return BadRequest(); // TODO: Handle this better.

            Claim nameIdentifier = authenticateResult.Principal.FindFirst(ClaimTypes.NameIdentifier);
            Claim name = authenticateResult.Principal.FindFirst(ClaimTypes.Name);

            var claimsIdentity = new ClaimsIdentity(type);
            claimsIdentity.AddClaim(nameIdentifier);
            claimsIdentity.AddClaim(name);

            Result<UserIdDto> result = await _userService.CreateUserAsync(nameIdentifier.Value, name.Value, type);

            claimsIdentity.AddClaim(new Claim(ClaimTypes.PrimarySid, result.Value.UserID));

            await HttpContext.SignInAsync("Cookies", new ClaimsPrincipal(claimsIdentity));

            return Redirect("/Account/Profile");
        }

        public IActionResult Profile()
        {
            return View();
        }
    }
}