using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AngularProjesiBusinessEngine.Contracts;
using AngularProjesiCommon.ResultConstant;

namespace AngularProjesiBusinessEngine.Contracts
{
    public interface IApplicationUserBusinessEngine
    {
        Task<Result<object>> CreateApplicationUser(ApplicationUserDto model);

        public object CreateApplicationUserDto(AngularProjesiCommon.Dtos.ApplicationUserDto model)
        {
            throw new NotImplementedException();
        }

        public object CreateApplicationUser(AngularProjesiCommon.Dtos.ApplicationUserDto model)
        {
            throw new NotImplementedException();
        }
    }
}
