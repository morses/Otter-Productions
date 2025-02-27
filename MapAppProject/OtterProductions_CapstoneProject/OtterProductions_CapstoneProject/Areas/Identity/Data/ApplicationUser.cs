﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace OtterProductions_CapstoneProject.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }

     
        [PersonalData]
        [Column(TypeName = "bit")]
        public bool IsOrganization { get; set; }
        //public string OrganizationName { get; set; }

        //[PersonalData]
        //[Column(TypeName = "nvarchar(50)")]
        //public string OrganizationDescription { get; set; }
        //[PersonalData]
        //[Column(TypeName = "nvarchar(50)")]
        //public string OrganizationLocation { get; set; }
    }



}
