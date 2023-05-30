using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class AppRole:IdentityRole<int>
    {
        public string RoleID { get; set; }
        public string SurName { get; set; }
        public string City { get; set; }
    }
}
