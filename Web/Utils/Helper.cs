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

        public static string GetUserId(ClaimsPrincipal principal)
        {
            var claim = principal.FindFirst(x => x.Type == ClaimTypes.PrimarySid);
            return claim != null ? claim.Value : null;
        }

        /*
         1 минуту
         2,3,4 минуты
         5,6,7,8,9,0 минут
        */
       

        public string GetRelativeTime(DateTime dateTime)
        {
            string result = string.Empty;
            var timeSpan = DateTime.UtcNow.Subtract(dateTime);

            if (timeSpan <= TimeSpan.FromSeconds(60))
            {
                int val = timeSpan.Seconds % 10;
                if (val == 1) return $"{timeSpan.Seconds} минуту";
            }
            else if (timeSpan <= TimeSpan.FromMinutes(60))
            {
                result = timeSpan.Minutes > 1 ?
                    String.Format("about {0} minutes ago", timeSpan.Minutes) :
                    "about a minute ago";
            }
            else if (timeSpan <= TimeSpan.FromHours(24))
            {
                result = timeSpan.Hours > 1 ?
                    String.Format("about {0} hours ago", timeSpan.Hours) :
                    "about an hour ago";
            }
            else if (timeSpan <= TimeSpan.FromDays(30))
            {
                result = timeSpan.Days > 1 ?
                    String.Format("about {0} days ago", timeSpan.Days) :
                    "yesterday";
            }
            else if (timeSpan <= TimeSpan.FromDays(365))
            {
                result = timeSpan.Days > 30 ?
                    String.Format("about {0} months ago", timeSpan.Days / 30) :
                    "about a month ago";
            }
            else
            {
                result = timeSpan.Days > 365 ?
                    String.Format("about {0} years ago", timeSpan.Days / 365) :
                    "about a year ago";
            }

            return result;
        }
    }
}
