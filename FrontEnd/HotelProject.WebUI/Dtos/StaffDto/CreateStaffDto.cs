using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.StaffDto
{
    public class CreateStaffDto
    {
        public int StaffID { get; set; }

        [Required(ErrorMessage = "Personel İsmi Giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Personel Unvanı Giriniz.")]
        public string Title { get; set; }
        public string SocialMedia { get; set; }

    }
}
