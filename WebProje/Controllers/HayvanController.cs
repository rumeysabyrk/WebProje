using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Models;

namespace WebProje.Controllers
{
    [Authorize(Roles = "admin")]
    public class HayvanController : Controller
    {
        HayvanBarinagiContext context = new HayvanBarinagiContext();

        [HttpGet]
        public async Task<IActionResult> Index()
        {
           var hayvan = await context.Hayvan.ToListAsync();
            return View(hayvan);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Hayvanlar hayvan)
        {
            var h = new Hayvanlar()
            {
                HayvanAdi = hayvan.HayvanAdi,
                Tur = hayvan.Tur,
                Sahiplenildimi = false
            };
            await context.Hayvan.AddAsync(h);
            await context.SaveChangesAsync();
            return RedirectToAction("Create");

        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            var hayvan = await context.Hayvan.FirstOrDefaultAsync(x => x.Id == id);
            if(hayvan != null)
            {
                var viewModel = new Hayvanlar()
                {
                    Id = hayvan.Id,
                    HayvanAdi = hayvan.HayvanAdi,
                    Tur = hayvan.Tur,
                    Sahiplenildimi = hayvan.Sahiplenildimi
                };
                return View(viewModel);
            }
            
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Edit( Hayvanlar model)
        {
            var hayvan = await context.Hayvan.FindAsync(model.Id);
            if(hayvan != null)
            {
                hayvan.HayvanAdi = model.HayvanAdi;
                hayvan.Tur = model.Tur;
                hayvan.Sahiplenildimi = model.Sahiplenildimi;
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hayvan = await context.Hayvan
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hayvan == null)
            {
                return NotFound();
            }

            return View(hayvan);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Hayvanlar model)
        {
            var hayvan = context.Hayvan.Find(model.Id);
            if(hayvan != null)
            {
                context.Hayvan.Remove(hayvan);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }

}
