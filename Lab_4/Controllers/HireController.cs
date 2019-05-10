using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab_4.Models;

namespace Lab_4.Controllers
{
    public class HireController : Controller
    {
        private readonly HireContext _context;

        public HireController(HireContext context)
        {
            _context = context;
        }

        // GET: Hire
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hire.ToListAsync());
        }

        // GET: Hire/Create
        public IActionResult AddOrEdit(int id=0)
        {
            if(id == 0)
            {
                return View(new Hire());
            }

            else
            {
                return View(_context.Hire.Find(id));
            }
                
        }

        // POST: Hire/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("HireId,FullNameClient,ClientCode,ClientAddress,ClientPhone,NameGoods,DescriptionGoods,PriceGoods,DateIssue,DateReturn,PriceHireOnDay")] Hire hire)
        {
            if (ModelState.IsValid)
            {
                if(hire.HireId == 0)
                    _context.Add(hire);
                else
                    _context.Update(hire);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hire);
        }

        // GET: Hire/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var hire = await _context.Hire.FindAsync(id);
            _context.Hire.Remove(hire);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
