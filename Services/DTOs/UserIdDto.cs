using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs
{
    public class UserIdDto
    {
        public UserIdDto(string userID) => UserID = userID;

        public string UserID { get; set; }
    }
}
