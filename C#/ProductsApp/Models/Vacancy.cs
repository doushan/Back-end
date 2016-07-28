using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Vacancy
    {
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string Skills { get; set; }
        public string Department { get; set; }
        public int Id { get; set; }
    }
}