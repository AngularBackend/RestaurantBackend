using AngularProjesiData.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularProjesi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        public ApplicationUserController(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager, UserManager<ApplicationUser> userManger, SignInManager<ApplicationUser> signInManager) //Constractor oluşturduk:Çünkü DependencyInjection yaklaşımını kullanabilmek için

        {
            //Inject işlemini gerçekleştirdik
            _userManager = userManger;
            _signInManager = signInManager;
        }
    }
}
