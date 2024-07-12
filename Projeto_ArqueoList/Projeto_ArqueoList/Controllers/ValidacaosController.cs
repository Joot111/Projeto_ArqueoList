using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_ArqueoList.Data;
using Projeto_ArqueoList.Models;

namespace Projeto_ArqueoList.Controllers
{
    public class ValidacaosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ValidacaosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Validacaos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Validacao.Include(v => v.AdminValidacao).Include(v => v.ValidacaoArtigo);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Validacaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var validacao = await _context.Validacao
                .Include(v => v.AdminValidacao)
                .Include(v => v.ValidacaoArtigo)
                .FirstOrDefaultAsync(m => m.ID_Validacao == id);
            if (validacao == null)
            {
                return NotFound();
            }

            return View(validacao);
        }

        // GET: Validacaos/Create
        public IActionResult Create()
        {
            ViewData["ID_Administrador"] = new SelectList(_context.Administradores, "idUtilizador", "Password");
            ViewData["ID_Artigo"] = new SelectList(_context.Artigos, "ID", "ID");
            return View();
        }

        // POST: Validacaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_Validacao,Estado,Motivo,data_validacao,ID_Artigo,ID_Administrador")] Validacao validacao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(validacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ID_Administrador"] = new SelectList(_context.Administradores, "idUtilizador", "Password", validacao.ID_Administrador);
            ViewData["ID_Artigo"] = new SelectList(_context.Artigos, "ID", "ID", validacao.ID_Artigo);
            return View(validacao);
        }

        // GET: Validacaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var validacao = await _context.Validacao.FindAsync(id);
            if (validacao == null)
            {
                return NotFound();
            }
            ViewData["ID_Administrador"] = new SelectList(_context.Administradores, "idUtilizador", "Password", validacao.ID_Administrador);
            ViewData["ID_Artigo"] = new SelectList(_context.Artigos, "ID", "ID", validacao.ID_Artigo);
            return View(validacao);
        }

        // POST: Validacaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID_Validacao,Estado,Motivo,data_validacao,ID_Artigo,ID_Administrador")] Validacao validacao)
        {
            if (id != validacao.ID_Validacao)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(validacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ValidacaoExists(validacao.ID_Validacao))
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
            ViewData["ID_Administrador"] = new SelectList(_context.Administradores, "idUtilizador", "Password", validacao.ID_Administrador);
            ViewData["ID_Artigo"] = new SelectList(_context.Artigos, "ID", "ID", validacao.ID_Artigo);
            return View(validacao);
        }

        // GET: Validacaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var validacao = await _context.Validacao
                .Include(v => v.AdminValidacao)
                .Include(v => v.ValidacaoArtigo)
                .FirstOrDefaultAsync(m => m.ID_Validacao == id);
            if (validacao == null)
            {
                return NotFound();
            }

            return View(validacao);
        }

        // POST: Validacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var validacao = await _context.Validacao.FindAsync(id);
            if (validacao != null)
            {
                _context.Validacao.Remove(validacao);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ValidacaoExists(int id)
        {
            return _context.Validacao.Any(e => e.ID_Validacao == id);
        }
    }
}
