using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.PowerBI.Api.Models;
using WebProje.Data;
using WebProje.Models;

namespace WebProje.Controllers
{
    public class SahiplenmeController : Controller
    {
        HayvanBarinagiContext context = new HayvanBarinagiContext();
        [Authorize(Roles = "admin,user")]
        [HttpGet]
       public IActionResult Index(int? id)
        {
            ViewData["id"] = id;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index( Sahiplenme yeni,int id)
        {
            var istek = new Sahiplenme()
            {
                HayvanId = id,
                isim = yeni.isim,
                soyIsim = yeni.soyIsim,
                TC = yeni.TC,
                dogumTarihi = yeni.dogumTarihi,
                adres = yeni.adres,
                soru1 = yeni.soru1,
                soru2 = yeni.soru2,
                soru3 = yeni.soru3,
                soru4=yeni.soru4,
                
            };
            await context.Sahiplenme.AddAsync(istek);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var sahiplenme = await context.Sahiplenme.ToListAsync();
            return View(sahiplenme);
        }
        public async Task<IActionResult> Kabul(int? id)
        {
            var hayvan = await context.Hayvan.FirstOrDefaultAsync(x => x.Id == id );
            hayvan.Sahiplenildimi = true;
            await context.SaveChangesAsync();
            return RedirectToAction("List");
        }
        public async Task<IActionResult> Reddet(int? id)
        {
            var hayvan = await context.Hayvan.FirstOrDefaultAsync(x => x.Id == id);
            var sahip = await context.Sahiplenme.FirstOrDefaultAsync(x => x.HayvanId == id);
            hayvan.Sahiplenildimi = false;
            context.Sahiplenme.Remove(sahip);
            await context.SaveChangesAsync();
            return RedirectToAction("List");
        }
    }
}
