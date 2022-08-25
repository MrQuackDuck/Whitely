using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Whitely.DAL.Interfaces;
using Whitely.Domain;
using Whitely.Domain.Models;
using Whitely.Models;

namespace Whitely.Controllers
{
    public class HomeController : Controller
    {
        private IRealPropertyRepository _repository;
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IRealPropertyRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index()
        {
            List<RealProperty> properties = _repository.Select();
            foreach(var item in properties)
            {
                if(item.Title.Length > 100)
                {
                    item.Title = item.Title.Substring(0, 100);
                }
                if (item.Text.Length > 180)
                {
                    item.Text = item.Text.Substring(0, 180) + "...";
                }
            }
            
            return View(properties);
        }

        public IActionResult Offers(int id = 1)
        {
            List<RealProperty> properties = _repository.Select();
            foreach (var item in properties)
            {
                if (item.Title.Length > 100)
                {
                    item.Title = item.Title.Substring(0, 100);
                }
                if (item.Text.Length > 180)
                {
                    item.Text = item.Text.Substring(0, 180) + "...";
                }
            }

            ViewBag.TotalPages = Math.Ceiling(properties.Count / 9.0);
            ViewBag.Id = id;
            properties = properties.Skip((id - 1) * 9).Take(8).ToList();

            return View(properties.ToList());
        }

        public IActionResult Find(int id = 1, string searchString = "")
        {
            int Id = 0;
            try { Id = Int32.Parse(searchString); }
            catch { }

            if (searchString == null)
                searchString = "";
            List<RealProperty> RealProperties = _repository.Select().Where(realprop => realprop.Title.ToLower().Contains(searchString.ToLower()) || realprop.Id == Id).ToList();
            ViewBag.TotalPages = Math.Ceiling(RealProperties.Count / 8.0);
            ViewBag.Id = id;
            RealProperties = RealProperties.Skip((id - 1) * 8).Take(8).ToList();

            foreach (var item in RealProperties)
            {
                if (item.Title.Length > 100)
                {
                    item.Title = item.Title.Substring(0, 100);
                }
                if (item.Text.Length > 180)
                {
                    item.Text = item.Text.Substring(0, 180) + "...";
                }
            }

            return View(RealProperties.ToList());
        }


        public IActionResult Offer(int id)
        {
            OfferResponse response = new OfferResponse();
            response.OfferResponse_ = _repository.Get(id);
            response.OffersResponse_ = _repository.Select();

            foreach (var item in response.OffersResponse_)
            {
                if (item.Title.Length > 100)
                {
                    item.Title = item.Title.Substring(0, 100);
                }
                if (item.Text.Length > 180)
                {
                    item.Text = item.Text.Substring(0, 180) + "...";
                }
            }
            return View(response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}