using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ElectronicStore.Data;
using ElectronicStore.Data.Models.Products;
using ElectronicStore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicStore.Web.Controllers
{
    public class PhotoCameraController:BaseController
    {

        public PhotoCameraController(ElectronicStoreContext db, IMapper mapper) : base(db, mapper) {}

        public IActionResult Index()
        {
            var photos = this.db.PhotoCameras
                .Select(x => this.mapper.Map<ProductViewModel>(x)).ToList();
            ViewBag.products = photos;
            ViewBag.Title = "Photo Cameras";
            ViewBag.ControllerName = "PhotoCameras";
            return this.View("ProductIndex");
        }

        public IActionResult Details(int id)
        {
            return this.View();
        }

    }
}
