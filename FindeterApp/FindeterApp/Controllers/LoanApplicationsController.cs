using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FindeterApp.Data;
using FindeterApp.Models;

namespace FindeterApp.Controllers
{
    public class LoanApplicationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoanApplicationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.LoanApplications.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loanApplication = await _context.LoanApplications
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loanApplication == null)
            {
                return NotFound();
            }

            return View(loanApplication);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CompanyName,Sector,ResourceUsage,CreditAmount,...")] LoanApplication loanApplication)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loanApplication);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loanApplication);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loanApplication = await _context.LoanApplications.FindAsync(id);
            if (loanApplication == null)
            {
                return NotFound();
            }
            return View(loanApplication);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CompanyName,Sector,ResourceUsage,CreditAmount,...")] LoanApplication loanApplication)
        {
            if (id != loanApplication.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loanApplication);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoanApplicationExists(loanApplication.Id))
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
            return View(loanApplication);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loanApplication = await _context.LoanApplications
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loanApplication == null)
            {
                return NotFound();
            }

            return View(loanApplication);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loanApplication = await _context.LoanApplications.FindAsync(id);
            _context.LoanApplications.Remove(loanApplication);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoanApplicationExists(int id)
        {
            return _context.LoanApplications.Any(e => e.Id == id);
        }
    }
}
