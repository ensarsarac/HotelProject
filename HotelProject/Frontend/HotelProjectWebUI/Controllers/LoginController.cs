using HotelProjectEntityLayer.Concrete;
using HotelProjectWebUI.Dtos.LoginDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProjectWebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {

        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View(new LoginUserDto());
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDto model)
        {
            if (ModelState.IsValid)
            {               
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var userLogin = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, false, false);
                    if (userLogin.Succeeded)
                    {
                        return RedirectToAction("Index", "Staff");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı.");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı.");
                }
                
            }
            
            return View(model);
        }

    }
}
