using AngularProjesiBusinessEngine.Contracts;
using AngularProjesiCommon.ResultConstant;
using AngularProjesiData.DbModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<Result<object>> CreateApplicationUser(ApplicationUserDto model)
        {
            var applicationUser = new ApplicationUser()
            {
                UserName = model.UserName,
                Email = model.Email,
                FullName = model.FullName
                
               
            };

            try
            {
                var result = await _userManager.CreateAsync(applicationUser);

                if(result.Errors.Count() > 0)

                return new Result<object>(false, ResultConstant.RecordCreated,result);

                return new Result<object>(true, ResultConstant.RecordCreated,result);

            }
            catch (Exception) 
            {
                return new Result<object>(false, ResultConstant.RecordNotCreated);
                
            }
        }

    }
}
