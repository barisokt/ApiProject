using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad Alanı Boş Bırakılamaz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad Alanı Boş Bırakılamaz.")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Kullanıcı Adı Alanı Boş Bırakılamaz.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mail Alanı Boş Bırakılamaz.")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Şifre Alanı Boş Bırakılamaz.")]
        public string PassWord { get; set; }
        [Required(ErrorMessage = "Şifre Tekrar Alanı Boş Bırakılamaz.")]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
