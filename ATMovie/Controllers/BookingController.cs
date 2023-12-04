using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ATMovie.Data;
using ATMovie.Models;

namespace ATMovie.Controllers
{
    public class BookingController : Controller
    {
        private readonly ATMovieContext _context;



        public BookingController(ATMovieContext context)
        {
            _context = context;
        }

        // GET: Booking
        public async Task<IActionResult> Index()
        {
            return _context.Booking != null ?
                        View(await _context.Booking.ToListAsync()) :
                        Problem("Entity set 'ATMovieContext.Booking'  is null.");
        }

        // GET: Booking/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewBag.Show = _context.Show.Where(a => a.Movie.MovieID == id)
                .Include(a => a.Movie).Include(a => a.Salon)
                .ThenInclude(a => a.SalonRows)
                .ThenInclude(a => a.Row)
                .ThenInclude(a => a.Seats);


            if (id == null || _context.Booking == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking
                .FirstOrDefaultAsync(m => m.BookingID == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // GET: Booking/Create
        public IActionResult Create(int? id)
        {
            Booking booking = new Booking();


            //ViewBag.Show = _context.Show.Where(a => a.ShowID == id).Include(a => a.Movie).Include(a => a.Salon).ThenInclude(a => a.Rows.Where(a.SalonID))            ;

            ViewBag.Show = _context.Show
            .Where(a => a.ShowID == id)
                .Include(a => a.Movie)
                .Include(a => a.Salon)
                .ThenInclude(s => s.SalonRows)
                .ThenInclude(s => s.Row)
                .ToList();
            if (ViewBag.Show == null)
            {
                return NotFound();
            }
            return View();
        }

        // POST: Booking/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingID,Kundnamn,Epost,ShowID")] Booking booking, int? id)
        {

            if (ModelState.IsValid)
            {

                booking.Show = _context.Show.FirstOrDefault(a => a.ShowID == id);
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("Index", "Bookings");
        }

        // GET: Booking/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Booking == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            return View(booking);
        }

        // POST: Booking/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingID,Kundnamn,Epost")] Booking booking)
        {
            if (id != booking.BookingID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.BookingID))
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
            return View(booking);
        }

        // GET: Booking/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Booking == null)
            {
                return NotFound();
            }

            var booking = await _context.Booking
                .FirstOrDefaultAsync(m => m.BookingID == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Booking/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Booking == null)
            {
                return Problem("Entity set 'ATMovieContext.Booking'  is null.");
            }
            var booking = await _context.Booking.FindAsync(id);
            if (booking != null)
            {
                _context.Booking.Remove(booking);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return (_context.Booking?.Any(e => e.BookingID == id)).GetValueOrDefault();
        }
    }
}
