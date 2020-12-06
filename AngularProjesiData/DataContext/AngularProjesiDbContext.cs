using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularProjesiData.DataContext
{
   public class AngularProjesiDbContext : IdentityDbContext
    {
        public AngularProjesiDbContext(DbContextOptions options) :base (options)
        {

        }

    }
}
