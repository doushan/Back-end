using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWebApi.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
    }

    //Entity Framework 5
    public class PersonEntities : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}