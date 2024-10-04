using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HealthSolutions_MVC.Models;

namespace HealthSolutions_MVC.Controllers
{
    public class PagamentoController : Controller
    {
        private readonly Contexto _context;

        public PagamentoController(Contexto context)
        {
            _context = context;
        }

        // GET: Pagamento
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Pagamento.Include(p => p.Consulta).Include(p => p.FormaPagamento);
            return View(await contexto.ToListAsync());
        }

        // GET: Pagamento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pagamento == null)
            {
                return NotFound();
            }

            var pagamento = await _context.Pagamento
                .Include(p => p.Consulta)
                .Include(p => p.FormaPagamento)
                .FirstOrDefaultAsync(m => m.PagamentoId == id);
            if (pagamento == null)
            {
                return NotFound();
            }

            return View(pagamento);
        }

        // GET: Pagamento/Create
        public IActionResult Create()
        {
            ViewData["ConsultaId"] = new SelectList(_context.Consulta, "ConsultaId", "ConsultaId");
            ViewData["FormaPagamentoId"] = new SelectList(_context.FormaPagamento, "FormaPagamentoId", "FormaPagamentoId");
            return View();
        }

        // POST: Pagamento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PagamentoId,ConsultaId,FormaPagamentoId,ValorPagamento,DataPagamento,ObsPagamento")] Pagamento pagamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pagamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ConsultaId"] = new SelectList(_context.Consulta, "ConsultaId", "ConsultaId", pagamento.ConsultaId);
            ViewData["FormaPagamentoId"] = new SelectList(_context.FormaPagamento, "FormaPagamentoId", "FormaPagamentoId", pagamento.FormaPagamentoId);
            return View(pagamento);
        }

        // GET: Pagamento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pagamento == null)
            {
                return NotFound();
            }

            var pagamento = await _context.Pagamento.FindAsync(id);
            if (pagamento == null)
            {
                return NotFound();
            }
            ViewData["ConsultaId"] = new SelectList(_context.Consulta, "ConsultaId", "ConsultaId", pagamento.ConsultaId);
            ViewData["FormaPagamentoId"] = new SelectList(_context.FormaPagamento, "FormaPagamentoId", "FormaPagamentoId", pagamento.FormaPagamentoId);
            return View(pagamento);
        }

        // POST: Pagamento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PagamentoId,ConsultaId,FormaPagamentoId,ValorPagamento,DataPagamento,ObsPagamento")] Pagamento pagamento)
        {
            if (id != pagamento.PagamentoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pagamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PagamentoExists(pagamento.PagamentoId))
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
            ViewData["ConsultaId"] = new SelectList(_context.Consulta, "ConsultaId", "ConsultaId", pagamento.ConsultaId);
            ViewData["FormaPagamentoId"] = new SelectList(_context.FormaPagamento, "FormaPagamentoId", "FormaPagamentoId", pagamento.FormaPagamentoId);
            return View(pagamento);
        }

        // GET: Pagamento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pagamento == null)
            {
                return NotFound();
            }

            var pagamento = await _context.Pagamento
                .Include(p => p.Consulta)
                .Include(p => p.FormaPagamento)
                .FirstOrDefaultAsync(m => m.PagamentoId == id);
            if (pagamento == null)
            {
                return NotFound();
            }

            return View(pagamento);
        }

        // POST: Pagamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pagamento == null)
            {
                return Problem("Entity set 'Contexto.Pagamento'  is null.");
            }
            var pagamento = await _context.Pagamento.FindAsync(id);
            if (pagamento != null)
            {
                _context.Pagamento.Remove(pagamento);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PagamentoExists(int id)
        {
          return (_context.Pagamento?.Any(e => e.PagamentoId == id)).GetValueOrDefault();
        }
    }
}
