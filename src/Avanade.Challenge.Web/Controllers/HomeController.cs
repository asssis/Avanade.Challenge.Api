using Avanade.Challenge.Api.Infra.Database.Domain;
using Avanade.Challenge.Api.Infra.Database.Repository;
using Avanade.Challenge.Infra.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Avanade.Challenge.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppContexto _context;

        public HomeController(AppContexto context)
        {
            _context = context;
        }
        public async Task<IActionResult> IndexAsync()
        {
            return View(await _context.Topics.ToListAsync()); 
        }

        public async Task<IActionResult> ActivityAsync(int? id)
        {
            var phrases = await _context.Phrases.Where(b => b.TopicId == id).ToListAsync();
            Phrase phrase = phrases[new Random().Next(phrases.Count())];

            return View(phrase);
        }
        [HttpPost]
        public IActionResult CheckinAsync(int? Id, string Answer)
        { 
            var phrase = _context.Phrases
                .Include(p => p.Topic)
                .FirstOrDefault(m => m.Id == Id);

            bool result = new PhraseRepository(_context).CheckPhrase(phrase, Answer);
            return Json(new { result = result });
        }
    }
}
