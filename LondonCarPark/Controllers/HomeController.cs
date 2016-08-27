using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LondonCarPark.Service;
using LondonCarPark.ModelMapper;
using LondonCarPark.Models;

namespace LondonCarPark.Controllers
{
    public class HomeController : Controller
    {
        IServiceFactory _service;
        public HomeController()
        {
            _service = new ServiceFactory();
        }
        // GET: Home
        public ActionResult Index()
        {
            var carParks = _service.GetCarParkService.GetList().Select(carPark => carPark.MapToCarParkViewModel());
           
            return View(carParks);
        }
    }
}