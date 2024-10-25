﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HealthSolutions_MVC.Models;

namespace HealthSolutions_MVC.Controllers
{
    public class TipoConsultaController : Controller
    {
        private readonly Contexto _context;

        public TipoConsultaController(Contexto context)
        {
            _context = context;
        }

        // GET: TipoConsulta
        public async Task<IActionResult> Index()
        {
              return _context.TipoConsulta != null ? 
                          View(await _context.TipoConsulta.ToListAsync()) :
                          Problem("Entity set 'Contexto.TipoConsulta'  is null.");
        }

        // GET: TipoConsulta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TipoConsulta == null)
            {
                return NotFound();
            }

            var tipoConsulta = await _context.TipoConsulta
                .FirstOrDefaultAsync(m => m.TipoConsultaId == id);
            if (tipoConsulta == null)
            {
                return NotFound();
            }

            return View(tipoConsulta);
        }

        // GET: TipoConsulta/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoConsulta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipoConsultaId,NomeTipoConsulta")] TipoConsulta tipoConsulta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoConsulta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoConsulta);
        }

        // GET: TipoConsulta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TipoConsulta == null)
            {
                return NotFound();
            }

            var tipoConsulta = await _context.TipoConsulta.FindAsync(id);
            if (tipoConsulta == null)
            {
                return NotFound();
            }
            return View(tipoConsulta);
        }

        // POST: TipoConsulta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TipoConsultaId,NomeTipoConsulta")] TipoConsulta tipoConsulta)
        {
            if (id != tipoConsulta.TipoConsultaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoConsulta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoConsultaExists(tipoConsulta.TipoConsultaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tipoConsulta);
        }

        // GET: TipoConsulta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TipoConsulta == null)
            {
                return NotFound();
            }

            var tipoConsulta = await _context.TipoConsulta
                .FirstOrDefaultAsync(m => m.TipoConsultaId == id);
            if (tipoConsulta == null)
            {
                return NotFound();
            }

            return View(tipoConsulta);
        }

        // POST: TipoConsulta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TipoConsulta == null)
            {
                return Problem("Entity set 'Contexto.TipoConsulta'  is null.");
            }
            var tipoConsulta = await _context.TipoConsulta.FindAsync(id);
            if (tipoConsulta != null)
            {
                _context.TipoConsulta.Remove(tipoConsulta);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoConsultaExists(int id)
        {
          return (_context.TipoConsulta?.Any(e => e.TipoConsultaId == id)).GetValueOrDefault();
        }
    }
}
