using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.AppServices;
using Services.QueryHandlers;

namespace Web.Utils
{
    public class Helper
    {
        public string GetUserUrl(HttpContext context) 
        {
            var claim = context.User.FindFirst("user_image");
            return claim.Value;
        }
    }
}
