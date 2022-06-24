using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Avanade.Challenge.Api.Infra.Database.Domain;
using Avanade.Challenge.Infra.Database;

namespace Avanade.Challenge.Web.Controllers
{
     
    public class PhrasesController : Controller
    {
        private readonly AppContexto _context;

        public PhrasesController(AppContexto context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var appContexto = _context.Phrases.Include(p => p.Topic);
            return View(await appContexto.ToListAsync());
        }
         
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phrase = await _context.Phrases
                .Include(p => p.Topic)
                .FirstOrDefaultAsync(m => m.TopicId == id);
            if (phrase == null)
            {
                return NotFound();
            }

            return View(phrase);
        }
         
        public IActionResult Create()
        {
            ViewData["TopicId"] = new SelectList(_context.Topics, "Id", "Id");
            return View();
        }
         
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Expression,TopicId")] Phrase phrase)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phrase);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TopicId"] = new SelectList(_context.Topics, "Id", "Id", phrase.TopicId);
            return View(phrase);
        }
         
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phrase = await _context.Phrases.FindAsync(id);
            if (phrase == null)
            {
                return NotFound();
            }
            ViewData["TopicId"] = new SelectList(_context.Topics, "Id", "Id", phrase.TopicId);
            return View(phrase);
        }
         
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Expression,TopicId")] Phrase phrase)
        {
            if (id != phrase.TopicId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phrase);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhraseExists(phrase.TopicId))
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
            ViewData["TopicId"] = new SelectList(_context.Topics, "Id", "Id", phrase.TopicId);
            return View(phrase);
        }
         
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phrase = await _context.Phrases
                .Include(p => p.Topic)
                .FirstOrDefaultAsync(m => m.TopicId == id);
            if (phrase == null)
            {
                return NotFound();
            }

            return View(phrase);
        }
         
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phrase = await _context.Phrases.FindAsync(id);
            _context.Phrases.Remove(phrase);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhraseExists(int id)
        {
            return _context.Phrases.Any(e => e.TopicId == id);
        }
    }
}
