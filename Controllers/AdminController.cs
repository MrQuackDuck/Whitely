using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Cryptography;
using Whitely.Domain.Models;
using Whitely.DAL.Interfaces;
using Whitely.Domain.Enum;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Whitely.DAL;


namespace Whitely.Controllers
{
    public class AdminController : Controller
    {
        private IRealPropertyRepository _repository;
        private IUserRepository _userRepository;

        private readonly IWebHostEnvironment _hostEnvironment;
        private ApplicationDbContext _dbContext;

        public AdminController(IRealPropertyRepository repository, IUserRepository userRepository, IWebHostEnvironment hostEnvironment, ApplicationDbContext context)
        {
            _repository = repository;
            _userRepository = userRepository;
            _hostEnvironment = hostEnvironment;
            _dbContext = context;
        }

        [Authorize]
        public IActionResult Panel()
        {
            var realProperties = _repository.Select();
            foreach (var item in realProperties)
            {
                if (item.Title.Length > 100)
                {
                    item.Title = item.Title.Substring(0, 100);
                }
                if (item.Text.Length > 150)
                {
                    item.Text = item.Text.Substring(0, 150) + "...";
                }
            }
            return View(realProperties);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            var realProperty = _repository.Get(id);
            return View(realProperty);
        }

        [HttpPost("login")]
        public async Task<IActionResult> AuthenticateAsync(string login, string password)
        {
            var user = _userRepository.GetByUsername(login);
            
            if (login == $"{user.Username}" && password == $"{EncryptOperations.DecodeFrom64(user.Password)}")
            {
                var claims = new List<Claim>();
                claims.Add(new Claim("login", login));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, login));
                claims.Add(new Claim("password", password));
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                return RedirectToAction("Panel");
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> NewRealPropAsync(string title, Categories type, string text, int? rent, int? buy, decimal area, [FromForm(Name = "image")] IFormFile image)
        {
            if(image != null)
            {
                RealProperty realProperty = new RealProperty()
                {
                    Title = title,
                    Type = type,
                    Text = text,
                    RentPrice = rent,
                    BuyPrice = buy,
                    Area = area,
                    DateAdded = DateTime.Now
                };
                _repository.Create(realProperty);

                //Save image to wwwroot/image
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(image.FileName);
                string extension = Path.GetExtension(image.FileName);
                fileName = fileName + extension;
                string path = Path.Combine(wwwRootPath + "/img/", $"{realProperty.Id}.jpg");
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await image.CopyToAsync(fileStream);
                }

                return Redirect($"/Home/Offer/{ realProperty.Id }");
            }
            
            return RedirectToAction($"Panel", "Admin");

        }

        public IActionResult DeleteRealProperty(int id)
        {
            _repository.Delete(_repository.Get(id));
            return RedirectToAction("Panel", "Admin");
        }

        public async Task<IActionResult> EditRealProperty(int id, string title, Categories type, string text, int? rent, int? buy, decimal area, [FromForm(Name = "image")] IFormFile image)
        {
            var realProperty = _repository.Get(id);
            realProperty.Title = title;
            realProperty.Type = type;
            realProperty.Text = text;
            realProperty.RentPrice = rent;
            realProperty.BuyPrice = buy;
            realProperty.Area = area;
            
            if(image != null)
            {
                _repository.DeleteImage(realProperty.Id);

                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(image.FileName);
                string extension = Path.GetExtension(image.FileName);
                fileName = fileName + extension;
                string path = Path.Combine(wwwRootPath + "/img/", $"{realProperty.Id}.jpg");
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await image.CopyToAsync(fileStream);
                }
            }

            _dbContext.SaveChanges();

            return Redirect($"/Home/Offer/{ realProperty.Id }");
        }

    }
}
