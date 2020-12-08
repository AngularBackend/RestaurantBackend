using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AngularProjesiBusinessEngine.Contracts;
using AngularProjesiCommon.ResultConstant;

namespace AngularProjesiBusinessEngine.Contracts
{
   public class IApplicationUserBusinessEngine
    {
        public async Task<Result<ApplicationUserDto>> CreateApplicationUser(ApplicationUserDto model);

    }
}
