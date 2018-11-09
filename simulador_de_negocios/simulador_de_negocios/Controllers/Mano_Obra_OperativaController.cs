using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using simulador_de_negocios.Models;

namespace simulador_de_negocios.Controllers
{
    public class Mano_Obra_OperativaController : Controller
    {
        private readonly simulador_de_negociosContext _context;

        public Mano_Obra_OperativaController(simulador_de_negociosContext context)
        {
            _context = context;
        }

        // GET: Mano_Obra_Operativa
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mano_Obra_Operativa.ToListAsync());
        }

        // GET: Mano_Obra_Operativa/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mano_Obra_Operativa = await _context.Mano_Obra_Operativa
                .SingleOrDefaultAsync(m => m.manoobraoperativaID == id);
            if (mano_Obra_Operativa == null)
            {
                return NotFound();
            }

            return View(mano_Obra_Operativa);
        }

        // GET: Mano_Obra_Operativa/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mano_Obra_Operativa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("manoobraoperativaID,concepto,unidadmedia,preciounitario,cantidad,estimacionmensual,estimacionanual,servicioproducto,datosempresas")] Mano_Obra_Operativa mano_Obra_Operativa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mano_Obra_Operativa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mano_Obra_Operativa);
        }

        // GET: Mano_Obra_Operativa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mano_Obra_Operativa = await _context.Mano_Obra_Operativa.SingleOrDefaultAsync(m => m.manoobraoperativaID == id);
            if (mano_Obra_Operativa == null)
            {
                return NotFound();
            }
            return View(mano_Obra_Operativa);
        }

        // POST: Mano_Obra_Operativa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("manoobraoperativaID,concepto,unidadmedia,preciounitario,cantidad,estimacionmensual,estimacionanual,servicioproducto,datosempresas")] Mano_Obra_Operativa mano_Obra_Operativa)
        {
            if (id != mano_Obra_Operativa.manoobraoperativaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mano_Obra_Operativa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Mano_Obra_OperativaExists(mano_Obra_Operativa.manoobraoperativaID))
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
            return View(mano_Obra_Operativa);
        }

        // GET: Mano_Obra_Operativa/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mano_Obra_Operativa = await _context.Mano_Obra_Operativa
                .SingleOrDefaultAsync(m => m.manoobraoperativaID == id);
            if (mano_Obra_Operativa == null)
            {
                return NotFound();
            }

            return View(mano_Obra_Operativa);
        }

        // POST: Mano_Obra_Operativa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mano_Obra_Operativa = await _context.Mano_Obra_Operativa.SingleOrDefaultAsync(m => m.manoobraoperativaID == id);
            _context.Mano_Obra_Operativa.Remove(mano_Obra_Operativa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Mano_Obra_OperativaExists(int id)
        {
            return _context.Mano_Obra_Operativa.Any(e => e.manoobraoperativaID == id);
        }
    }
}
