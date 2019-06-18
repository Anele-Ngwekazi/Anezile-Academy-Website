using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using AnezileAcademy.Models;
using AnezileAcademy.Services;
using Microsoft.AspNetCore.Authorization;


namespace AnezileAcademy.Controllers
{
    [Authorize(Roles ="admin")]
    [Route("[controller]/[action]")]
    public class AcademyController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;

        public AcademyController(
  UserManager<ApplicationUser> userManager,
  SignInManager<ApplicationUser> signInManager,
  IEmailSender emailSender,
  ILogger<ManageController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _logger = logger;
        }


        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            return View();
        }

        public async Task<IActionResult> Addition()
        {
            var user = await _userManager.GetUserAsync(User);
            return View();
        }

        public async Task<IActionResult> Substraction()
        {
            var user = await _userManager.GetUserAsync(User);
            return View();
        }
    }
}
