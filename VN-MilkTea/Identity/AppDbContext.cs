﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace VN_MilkTea.Identity
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext() : base("MyconnectionString")
        {

        }
        
    }
}
