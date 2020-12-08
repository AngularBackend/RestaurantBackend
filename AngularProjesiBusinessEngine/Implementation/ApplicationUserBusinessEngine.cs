using AngularProjesiBusinessEngine.Contracts;
using AngularProjesiData.DbModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;



namespace AngularProjesiBusinessEngine.Implementation
{
    public class ApplicationUserBusinessEngine : IApplicationUserBusinessEngine
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        public ApplicationUserBusinessEngine(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager, UserManager<ApplicationUser> userManger, SignInManager<ApplicationUser> signInManager) //Constractor oluşturduk:Çünkü DependencyInjection yaklaşımını kullanabilmek için

        {
            //Inject işlemini gerçekleştirdik
            _userManager = userManger;
            _signInManager = signInManager;
        }

    }
}
