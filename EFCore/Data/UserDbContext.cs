using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using northwindAPI.EFCore.Data.Models;

namespace northwindAPI.northwindEFCore.Data
{
    public class UserDbContext:IdentityDbContext<User>
    {
        public UserDbContext(DbContextOptions<UserDbContext> options):base(options)
        {
            
        }
    }
}