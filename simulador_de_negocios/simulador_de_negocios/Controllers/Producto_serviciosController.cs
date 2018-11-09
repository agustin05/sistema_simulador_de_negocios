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
    public class Producto_serviciosController : Controller
    {
        private readonly simulador_de_negociosContext _context;

        public Producto_serviciosController(simulador_de_negociosContext context)
        {
            _context = context;
        }

        // GET: Producto_servicios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Producto_servicios.ToListAsync());
        }

        // GET: Producto_servicios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto_servicios = await _context.Producto_servicios
                .SingleOrDefaultAsync(m => m.productoID == id);
            if (producto_servicios == null)
            {
                return NotFound();
            }

            return View(producto_servicios);
        }

        // GET: Producto_servicios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Producto_servicios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("productoID,nombreproducto,unidadproducto,produccionmensual,costounitario,margenutilidad,preciopublico,datosempresa")] Producto_servicios producto_servicios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto_servicios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(producto_servicios);
        }

        // GET: Producto_servicios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto_servicios = await _context.Producto_servicios.SingleOrDefaultAsync(m => m.productoID == id);
            if (producto_servicios == null)
            {
                return NotFound();
            }
            return View(producto_servicios);
        }

        // POST: Producto_servicios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("productoID,nombreproducto,unidadproducto,produccionmensual,costounitario,margenutilidad,preciopublico,datosempresa")] Producto_servicios producto_servicios)
        {
            if (id != producto_servicios.productoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto_servicios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Producto_serviciosExists(producto_servicios.productoID))
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
            return View(producto_servicios);
        }

        // GET: Producto_servicios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto_servicios = await _context.Producto_servicios
                .SingleOrDefaultAsync(m => m.productoID == id);
            if (producto_servicios == null)
            {
                return NotFound();
            }

            return View(producto_servicios);
        }

        // POST: Producto_servicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto_servicios = await _context.Producto_servicios.SingleOrDefaultAsync(m => m.productoID == id);
            _context.Producto_servicios.Remove(producto_servicios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Producto_serviciosExists(int id)
        {
            return _context.Producto_servicios.Any(e => e.productoID == id);
        }
    }
}
