using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.RegisterDto;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class RegisterController : Controller
    {
      
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser>userManager)
        {
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Index(CreateNewUserDto createNewUserDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
          


            var appUser = new AppUser()
            {
                Name = createNewUserDto.Name,
                Email = createNewUserDto.Mail,
                SurName = createNewUserDto.SurName,
                UserName = createNewUserDto.UserName
            };
            var result = await _userManager.CreateAsync(appUser,createNewUserDto.PassWord);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        } 
    }
}
