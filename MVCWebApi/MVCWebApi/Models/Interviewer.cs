using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWebApi.Models
{
    public class Interviewer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Comments { get; set; }
      
    }
    public class InterviewerEntities : DbContext
    {
        public DbSet<Interviewer> Interviewers { get; set; }
    }
}