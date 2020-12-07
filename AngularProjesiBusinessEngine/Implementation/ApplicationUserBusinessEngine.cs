using AngularProjesiBusinessEngine.Contracts;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;



namespace AngularProjesiBusinessEngine.Implementation
{
    public class ApplicationUserBusinessEngine : Contracts.ApplicationUserBusinessEngine
    {
        private UserManager<ApplicationUserBusinessEngine> _userManager;
        private SignInManager<ApplicationUserBusinessEngine> _signInManager;

        public ApplicationUserBusinessEngine(UserManager<ApplicationUserBusinessEngine> _userManager, SignInManager<ApplicationUserBusinessEngine> _signInManager, UserManager<ApplicationUserBusinessEngine> userManger, SignInManager<ApplicationUserBusinessEngine> signInManager) //Constractor oluşturduk:Çünkü DependencyInjection yaklaşımını kullanabilmek için

        {
            //Inject işlemini gerçekleştirdik
            _userManager = userManger;
            _signInManager = signInManager;
        }

    }
}
