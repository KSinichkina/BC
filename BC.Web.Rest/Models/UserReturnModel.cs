﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BC.Web.Rest.Models
{
    public class UserReturnModel
    {
        public string Url { get; set; }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public DateTime JoinDate { get; set; }
        public IList<string> Roles { get; set; }
        public IList<System.Security.Claims.Claim> Claims { get; set; }
    }
}