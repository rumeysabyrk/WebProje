using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Models;

namespace WebProje.Controllers
{
    [Authorize(Roles="admin")]
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        public AdminController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Roller rol)
        {
            var roleExist = await roleManager.RoleExistsAsync(rol.RolAdi);
            if (!roleExist)
            {
                var result = await roleManager.CreateAsync(new IdentityRole(rol.RolAdi));
            }
            return View();
        }
    }
}
