using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecureChatApp.Models;

//using SecureChatApp.ViewModels;

namespace SecureChatApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           /* var homeViewModel = new HomeViewModel
            {
                ActiveUsers = _userRepository.ActiveUsers
            };

            return View(homeViewModel); */

            var model = new User{Id = 1, UserName = "Nilson"};
            return View("Index");
        }
    }
}
