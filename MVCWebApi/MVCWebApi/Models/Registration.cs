using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWebApi.Models
{
    public class Registration
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Position{ get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
    }
    public class RegistrationEntities : DbContext
    {
        public DbSet<Registration> Registrations { get; set; }
    }
}