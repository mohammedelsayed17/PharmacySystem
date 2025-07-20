using PharmacySystem.Data;
using PharmacySystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace PharmacySystem.Repositories
{
    // This is just here as an example of repository pattern
    public class MedicineRepository : IMedicineRepository
    {
        private readonly AppDbContext _context;

        public MedicineRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Medicine> GetAll(string? search = null)
        {
            return string.IsNullOrEmpty(search)
                ? _context.Medicines.ToList()
                : _context.Medicines.Where(m => m.Name.Contains(search)).ToList();
        }

        public Medicine GetById(int id) => _context.Medicines.Find(id);

        public void Add(Medicine medicine) => _context.Medicines.Add(medicine);

        public void Update(Medicine medicine) => _context.Medicines.Update(medicine);

        public void Delete(int id)
        {
            var med = _context.Medicines.Find(id);
            if (med != null) _context.Medicines.Remove(med);
        }

        public void Save() => _context.SaveChanges();
    }
}
