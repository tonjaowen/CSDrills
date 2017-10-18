using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicketChallenge.Data;
using TicketChallenge.Models;
using Microsoft.AspNetCore.Authorization;

namespace TicketChallenge.Controllers
{
     [Authorize]
    public class TicketsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TicketsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Tickets
        public async Task<IActionResult> Index()
        {
            var tickets = await _context.Tickets.Where(p => p.Closed == false).ToListAsync();
            return View(tickets);
        }

        // GET: Tickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets
                .SingleOrDefaultAsync(m => m.TicketId == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // GET: Tickets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TicketId,Name,Description")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                ticket.OpenBy = HttpContext.User.Identity.Name;

                _context.Add(ticket);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ticket);
        }

        // GET: Tickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets.SingleOrDefaultAsync(m => m.TicketId == id);
            if (ticket == null)
            {
                return NotFound();
            }
            return View(ticket);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TicketId,Name,Description,Closed")] Ticket vm)
        {
            
            if (id != vm.TicketId)
            {
                return NotFound();
            }
            

            if (ModelState.IsValid)
            {
                try
                {
                    //Get the DATABASE version of the Ticket
                    var ticket = _context.Tickets.FirstOrDefault(p => p.TicketId == id);
                    //Compare the DATABASE version versus the HTTP FORM version
                    //Update the values in the DATABASE version

                    ticket.Name = vm.Name;
                    ticket.Description = vm.Description;
                    ticket.Closed = vm.Closed;

                    if (ticket.Closed == true)
                    {
                        ticket.CloseBy = HttpContext.User.Identity.Name;
                    }

                    //Save the DATABASE version.


                    _context.Update(ticket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    /* if (!TicketExists(ticket.TicketId))
                     {
                         return NotFound();
                     }
                     else
                     {
                         throw;
                     }
                 }
                 */
                }
                return RedirectToAction("Index");
            }
            return View(vm);
        }

        // GET: Tickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets
                .SingleOrDefaultAsync(m => m.TicketId == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ticket = await _context.Tickets.SingleOrDefaultAsync(m => m.TicketId == id);
            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool TicketExists(int id)
        {
            return _context.Tickets.Any(e => e.TicketId == id);
        }
    }
}
