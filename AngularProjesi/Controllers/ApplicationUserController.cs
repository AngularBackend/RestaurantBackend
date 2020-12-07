using AngularProjesiCommon.Dtos;
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


        public async Task<Object> PostApplicationUser(ApplicationUserDto model)
        {

        }

    }
}
