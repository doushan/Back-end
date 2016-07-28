using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Applicant
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Nic { get; set; }
        public string Passport { get; set; }
        public string JobTitle { get; set; }
        public string Nationality { get; set; }
        public string Skills { get; set; }
        public int PhoneNum { get; set; }
        public int HomeNum { get; set; }
        public string DateApplied { get; set; }
        public string Email { get; set; }
        public string Interview { get; set; }
    }
}