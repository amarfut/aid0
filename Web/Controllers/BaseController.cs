using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Utils;


namespace Web.Controllers
{
    public class BaseController : Controller
    {
        protected string UserId
        {
            get
            {
                var claim = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.PrimarySid);
                return claim.Value;
            }
        }

        protected string UserName
        {
            get
            {
                var claim = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name);
                return claim.Value;
            }
        }

        protected IActionResult FromResult(Result result)
        {
            return result.Success ? (IActionResult)Ok() : BadRequest(result.Error);
        }
    }
}