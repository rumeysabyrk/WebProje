using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class SahiplenmeController : Controller
    {
        [Authorize(Roles = "admin,user")]
        [HttpGet]
       public IActionResult Index()
        {
            return View();
        }
    }
}
