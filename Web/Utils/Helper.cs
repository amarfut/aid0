using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.AppServices;
using Services.QueryHandlers;
using System.Security.Claims;
using Common;
using Microsoft.AspNetCore.Http;

namespace Web.Utils
{
    public class Helper
    {
        public static string GetUserPhotoUrl(ClaimsPrincipal principal)
        {
            
            var claim = principal.FindFirst(x => x.Type == Constants.ProfileImage);
            return claim != null ? claim.Value : Constants.NoPhoto;
        }
    }
}
