using PharmacySystem.Models;

namespace PharmacySystem.Services
{
    public interface IMedicineRepository
    {
        IEnumerable<Medicine> GetAll(string? filter = null);
        Medicine GetById(int id);
        void Add(Medicine med);
        void Update(Medicine med);
        void Delete(int id);
        void Save();
    }
}
