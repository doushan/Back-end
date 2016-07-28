using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class StaffController : ApiController
    {
        Staff[] staff  = new Staff[]
        {
            new Staff{Id = 1, FirstName = "Doushan", LastName = "Goolab", Username = "ddd", Password = "1234", ConfirmPassword = "1234", PhoneNumber = "14253628", ResidenceNumber = "7896321", Email = "doushan@live.com", Address = "Vacoas", JobTitle = "Developer"},
            new Staff{Id = 2, FirstName = "Bonie", LastName = "Coder", Username = "bbb", Password = "555", ConfirmPassword = "555", PhoneNumber = "78963254", ResidenceNumber = "7896325", Email = "bonie@live.com", Address = "Quatre Borne", JobTitle = "Developer"}
           
        };

        public IEnumerable<Staff> GetAllStaff()
        {
            return staff;
        }

        public IHttpActionResult GetStaff(int id)
        {
            var _staff = staff.FirstOrDefault((p) => (p.Id == id));
            if (_staff == null)
            {
                return NotFound();
            }
            return Ok(_staff);
        }
    }
}