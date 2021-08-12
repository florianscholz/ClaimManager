using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ClaimManager.Authentication;
using ClaimManager.DataLayer.DbContext;
using ClaimManager.DataLayer.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ClaimManager.Models;
using Microsoft.AspNetCore.Authorization;

namespace ClaimManager.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserRepository _userRepository;

        public AuthController(IAuthenticationService authenticationService,
            IUserRepository userRepository)
        {
            this._authenticationService = authenticationService;
            this._userRepository = userRepository;
        }

        /// <summary>  
        /// Gets or sets login model property.  
        /// </summary>  
        [BindProperty]
        public LoginViewModel LoginModel { get; set; }

        public ViewResult Login()
        {
            return View("Login");
        }

        public async Task<IActionResult> DoLogin()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _userRepository.TestCredentials(LoginModel.Username, LoginModel.Password);
                    await _authenticationService.SignIn(HttpContext, "horst");
                    return RedirectToAction("Index", "Home");
                }
                catch (InvalidUserException)
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password.");
                    return this.Login();
                }
                catch (InactiveUserException)
                {
                    ModelState.AddModelError(string.Empty, "The user is inactive.");
                    return this.Login();
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt.");
                return this.Login();
            }
        }
    }
}