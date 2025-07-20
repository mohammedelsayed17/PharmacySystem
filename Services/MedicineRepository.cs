using PharmacySystem.Data;
using PharmacySystem.Models;

namespace PharmacySystem.Services
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly AppDbContext _context;
        public MedicineRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Medicine med) => _context.Medicines.Add(med);

        public void Delete(int id)
        {
            var med = _context.Medicines.Find(id);
            if (med != null) _context.Medicines.Remove(med);
        }

        public IEnumerable<Medicine> GetAll(string? filter = null)
        {
            return string.IsNullOrEmpty(filter)
                ? _context.Medicines.ToList()
                : _context.Medicines.Where(m => m.Name.Contains(filter)).ToList();
        }

        public Medicine GetById(int id) => _context.Medicines.Find(id);

        public void Save() => _context.SaveChanges();

        public void Update(Medicine med) => _context.Medicines.Update(med);
    }
}
