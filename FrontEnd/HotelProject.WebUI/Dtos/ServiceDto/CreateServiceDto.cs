using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
      [Required(ErrorMessage ="Hizmet İkon Linki Giriniz.")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet Başlığı Giriniz.")]
        [StringLength(100,ErrorMessage ="Lütfen En Fazla 100 Karakter Giriniz.")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
