using BookstoreProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookstoreProject.Controllers
{
    public class StoreController : Controller
    {
        private readonly BookstoreProjectContext _context;

        public StoreController(BookstoreProjectContext context)
        {
            _context = context;
        }

        // GET: Store
        public async Task<IActionResult> Index()
        {
            return _context.Book != null ?
                        View(await _context.Book.ToListAsync()) :
                        Problem("Entity set 'BookstoreProjectContext.Book'  is null.");
        }

        // GET: Store/Purchase/5
        public async Task<IActionResult> Purchase(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }
        public async Task<IActionResult> Confirmation(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }
    }
}
