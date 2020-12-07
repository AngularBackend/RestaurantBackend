using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AngularProjesiData.DbModels
{
   public class ApplicationUser :IdentityUser //ASPNETUser tablosunu bana verecek
    {
        [Column(TypeName = "nvarchar(150")]
        public string FullName { get; set; }
    }
}
