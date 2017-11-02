using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using imagesweb.Models;

namespace imagesweb.Controllers
{
    public class ImageController : Controller
    {
        private IHostingEnvironment _Env;
        public ImageController(IHostingEnvironment envrnmt)
        {
            _Env = envrnmt;
        }

        public IActionResult Index()
        {
            return View(new ImageModel(_Env.WebRootPath));
        }
    }
}