using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Common;
using DataAccess;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.AppServices;
using Services.DTOs;
using Services.Utils;
using Web.Utils;

namespace Web.Controllers
{
    public class InfoController : BaseController
    {
        [Route("/about")]
        public IActionResult About()
        {
            return View();
        }

        [Route("/contacts")]
        public IActionResult Contacts()
        {
            return View();
        }

        [Route("/cookies")]
        public IActionResult Cookies()
        {
            return View();
        }

        [Route("/privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("/termsandconditions")]
        public IActionResult TermsAndConditions()
        {
            return View();
        }


        public async Task<IActionResult> SendMessage([FromBody] Message message)
        {
            var valid = message.IsValid();
            if (!valid)
            {
                return FromResult(Result.Fail("Все поля обязательны для заполнения."));
            }

            await new DatabaseContext().UserMessages.InsertOneAsync(new Domain.Entities.UserMessage()
            {
                Name = message.Name,
                Mail = message.Mail,
                Subject = message.Subject,
                Text = message.Text,
                Created = DateTime.UtcNow
            });

            return FromResult(Result.Ok());
        }

        public class Message
        {
            public string Subject { get; set; }
            public string Name { get; set; }
            public string Mail { get; set; }
            public string Text { get; set; }

            public bool IsValid()
            {
                return 
                    !string.IsNullOrEmpty(Subject) && 
                    !string.IsNullOrEmpty(Name) && 
                    !string.IsNullOrEmpty(Mail) && 
                    !string.IsNullOrEmpty(Text);
            }
        }
    }
}