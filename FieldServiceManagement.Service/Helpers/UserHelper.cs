using FieldServiceManagement.Core.DTOs;
using FieldServiceManagement.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldServiceManagement.Service.Helpers
{
    public class UserHelper
    {
        private readonly UserManager<AppUser> _userManager;

        public UserHelper(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public string GetUserRole(AppUser appUser)
        {
            var userRoles = _userManager.GetRolesAsync(appUser).Result;

            if (userRoles.Count==0) return "Rol Yok";
            
            return userRoles.First();
        }
    }
}
