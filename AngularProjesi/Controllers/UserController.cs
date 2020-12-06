using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AngularProjesi.Controllers
{
    public class UserController : Controller //Controller ve Action aracığıyla Business Engine Katmanına gidecez
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
