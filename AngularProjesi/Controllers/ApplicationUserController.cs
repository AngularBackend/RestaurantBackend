using AngularProjesiBusinessEngine.Contracts;
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

        private readonly IApplicationUserBusinessEngine _applicationUserBusinessEngine;

        public ApplicationUserController(IApplicationUserBusinessEngine applicationUserBusinessEngine)
        {
            _applicationUserBusinessEngine = applicationUserBusinessEngine;
        }

        [HttpGet("Index")]
       
        public IActionResult Index()
        {
           
            return Ok();
        }

        [HttpPost]
        [Route("Register")]

        public async Task<Object> PostApplicationUser(ApplicationUserDto model)
        {
            var data =  _applicationUserBusinessEngine.CreateApplicationUser(model);
            var result = data;
            return Ok(result);
        }

    }

    
}
