using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Projeto_ArqueoList.Data;
using Projeto_ArqueoList.Models;

namespace Projeto_ArqueoList.Controllers
{
    public class UtilizadorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<UtilizadorsController> _logger;

        public UtilizadorsController(ApplicationDbContext context, ILogger<UtilizadorsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: Utilizadors
        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("Utilizadors/Index accessed");
            return View(await _context.Utilizadors.ToListAsync());
        }

        // GET: Utilizadors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                _logger.LogWarning("Utilizadors/Details accessed with null ID");
                return NotFound();
            }

            var utilizador = await _context.Utilizadors.FirstOrDefaultAsync(m => m.ID == id);
            if (utilizador == null)
            {
                _logger.LogWarning($"Utilizadors/Details accessed with invalid ID: {id}");
                return NotFound();
            }

            _logger.LogInformation($"Utilizadors/Details accessed for ID: {id}");
            return View(utilizador);
        }

        // GET: Utilizadors/Create
        public IActionResult Create()
        {
            _logger.LogInformation("Utilizadors/Create accessed");
            return View();
        }

        // POST: Utilizadors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nome,Email,Password")] Utilizador utilizador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(utilizador);
                await _context.SaveChangesAsync();
                _logger.LogInformation($"New Utilizador created with ID: {utilizador.ID}");
                return RedirectToAction(nameof(Index));
            }
            _logger.LogWarning("Utilizadors/Create model state invalid");
            return View(utilizador);
        }

        // GET: Utilizadors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                _logger.LogWarning("Utilizadors/Edit accessed with null ID");
                return NotFound();
            }

            var utilizador = await _context.Utilizadors.FindAsync(id);
            if (utilizador == null)
            {
                _logger.LogWarning($"Utilizadors/Edit accessed with invalid ID: {id}");
                return NotFound();
            }

            _logger.LogInformation($"Utilizadors/Edit accessed for ID: {id}");
            return View(utilizador);
        }

        // POST: Utilizadors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nome,Email,Password")] Utilizador utilizador)
        {
            if (id != utilizador.ID)
            {
                _logger.LogWarning($"Utilizadors/Edit POST accessed with mismatched ID: {id}");
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(utilizador);
                    await _context.SaveChangesAsync();
                    _logger.LogInformation($"Utilizador updated with ID: {utilizador.ID}");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UtilizadorExists(utilizador.ID))
                    {
                        _logger.LogWarning($"Utilizadors/Edit concurrency issue with ID: {utilizador.ID}");
                        return NotFound();
                    }
                    else
                    {
                        _logger.LogError($"Utilizadors/Edit concurrency exception for ID: {utilizador.ID}");
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            _logger.LogWarning("Utilizadors/Edit model state invalid");
            return View(utilizador);
        }

        // GET: Utilizadors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                _logger.LogWarning("Utilizadors/Delete accessed with null ID");
                return NotFound();
            }

            var utilizador = await _context.Utilizadors.FirstOrDefaultAsync(m => m.ID == id);
            if (utilizador == null)
            {
                _logger.LogWarning($"Utilizadors/Delete accessed with invalid ID: {id}");
                return NotFound();
            }

            _logger.LogInformation($"Utilizadors/Delete accessed for ID: {id}");
            return View(utilizador);
        }

        // POST: Utilizadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var utilizador = await _context.Utilizadors.FindAsync(id);
            if (utilizador != null)
            {
                _context.Utilizadors.Remove(utilizador);
                await _context.SaveChangesAsync();
                _logger.LogInformation($"Utilizador deleted with ID: {id}");
            }
            else
            {
                _logger.LogWarning($"Utilizadors/DeleteConfirmed accessed with invalid ID: {id}");
            }

            return RedirectToAction(nameof(Index));
        }

        private bool UtilizadorExists(int id)
        {
            return _context.Utilizadors.Any(e => e.ID == id);
        }
    }
}
