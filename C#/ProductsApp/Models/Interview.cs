using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Interview
    {
        public String ApplicantName { get; set; }
        public String JobTitle { get; set; }
        public String Interviewer { get; set; }
        public String Department { get; set; }
        public String DateApplied { get; set; }
        public String TimeApplied { get; set; }
    }
}