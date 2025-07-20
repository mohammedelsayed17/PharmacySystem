using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PharmacySystem.Data;
using PharmacySystem.Models;
using System.Security.Claims;

namespace PharmacySystem.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly AppDbContext _context;
        public CartController(AppDbContext context) => _context = context;

        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var items = _context.CartItems.Include(c => c.Medicine)
                        .Where(c => c.UserId == userId).ToList();
            ViewBag.Total = items.Sum(i => i.Medicine.Price * i.Quantity);
            return View(items);
        }

        public IActionResult Add(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var item = _context.CartItems.FirstOrDefault(c => c.UserId == userId && c.MedicineId == id);
            if (item == null)
            {
                _context.CartItems.Add(new CartItem { UserId = userId, MedicineId = id, Quantity = 1 });
            }
            else
            {
                item.Quantity++;
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            var item = _context.CartItems.Find(id);
            if (item != null) _context.CartItems.Remove(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
