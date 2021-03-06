﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using AnezileAcademy.Models;
using AnezileAcademy.Services;
using Microsoft.AspNetCore.Authorization;
using AnezileAcademy.Data;

namespace AnezileAcademy.Controllers
{
    [Authorize]
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

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            user.Role = (await _userManager.GetRolesAsync(user)).ToList<string>().FirstOrDefault();

            return View(user);
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult _teacherlist()
        { 
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "teacher")]
        public IActionResult _studentlist()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "parent")]
        public IActionResult _parentstudentlist()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "student")]
        public IActionResult _academyworkdetail()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "student")]
        public async Task<IActionResult> Exercises()
        {
            var user = await _userManager.GetUserAsync(User);
            return View(user);
        }

        [HttpGet]
        [Authorize(Roles = "student")]
        public async Task<IActionResult> Assignments()
        {
            var user = await _userManager.GetUserAsync(User);
            return View(user);
        }

        [HttpGet]
        [Authorize(Roles = "student")]
        public async Task<IActionResult> Tests()
        {
            var user = await _userManager.GetUserAsync(User);
            return View();
        }
    }
}
