﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiPracDataModels
{
   public class Role : IdentityRole
    {
        public string RoleDescription { get; set; }

    }
}
