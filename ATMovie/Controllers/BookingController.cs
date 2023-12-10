using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ATMovie.Data;
using ATMovie.Models;
using Microsoft.EntityFrameworkCore.Update.Internal;
using static System.Net.Mime.MediaTypeNames;

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
        public async Task<IActionResult> Index(int? id)
        {
            if (id != null)
            {
                Booking booking = _context.Booking.Find(id);
                ViewBag.Booking = booking;

            }

            return View();

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

            ViewBag.Show = _context.Show
            .Where(a => a.ShowID == id)
                .Include(a => a.Movie)
                .Include(a => a.Salon)
                .ThenInclude(s => s.SalonRows)
                .ThenInclude(s => s.Row)
                .ThenInclude(s => s.Seats)
                .ThenInclude(s => s.Seat)
                .ToList();
            if (ViewBag.Show == null)
            {
                return NotFound();
            }
            return View();
        }






        [BindProperty]
        public string SelectedSeats { get; set; }



        public IActionResult CheckSeats()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BookSeats(string selectedSeats)
        {
            if (selectedSeats == null)
            {
                return Problem();
            }
            TempData["SelectedSeats"] = selectedSeats;
            return Ok();
        }

        // POST: Booking/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingID,Kundnamn,Epost,ShowID")] Booking booking, int? id)
        {

            int selectedRow = int.Parse(SelectedSeats.Split(",")[0].Trim('{', '}', ','));
            int selectedSeat = int.Parse(SelectedSeats.Split(",")[1].Trim('{', '}', ',', ' '));

            SalonRows salonRows = await _context.SalonRows
                .Include(s => s.Row)
                    .ThenInclude(a => a.Seats)
                    .ThenInclude(a => a.Seat)
                .FirstOrDefaultAsync(m => m.Row.Seats.Any(a => a.RowSeatId == selectedSeat));

            if (salonRows != null)
            {
                RowSeat test = salonRows.Row.Seats.FirstOrDefault(a => a.RowSeatId == selectedSeat && a.RowID == selectedRow);
                Seat seat = new Seat(test.Seat.IsBooked = true);
                test.Seat.IsBooked = seat.IsBooked;
            }
            if (ModelState.IsValid)
            {
                RowSeat rowSeat = salonRows.Row.Seats.FirstOrDefault(a => a.RowSeatId == selectedSeat && a.RowID == selectedRow);
                booking.Show = _context.Show.FirstOrDefault(a => a.ShowID == id);
                booking.Salon = _context.Salon.FirstOrDefault(a => a.SalonID == id);
                booking.RowSeat = rowSeat;

                _context.Add(booking);

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index), new { id = booking.BookingID });
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
