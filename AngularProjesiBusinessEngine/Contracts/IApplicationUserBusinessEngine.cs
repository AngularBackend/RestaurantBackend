using System;
using System.Collections.Generic;
using System.Text;
using AngularProjesiBusinessEngine.Contracts;
using AngularProjesiCommon.ResultConstant;

namespace AngularProjesiBusinessEngine.Contracts
{
   public class IApplicationUserBusinessEngine
    {
      Result<ApplicationUserDto> CreateApplicationUser(ApplicationUserDto model);

    }
}
