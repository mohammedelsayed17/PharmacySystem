using PharmacySystem.Models;
using System.Collections.Generic;

namespace PharmacySystem.Repositories
{
    // Just an interface definition for demonstration
    public interface IMedicineRepository
    {
        IEnumerable<Medicine> GetAll(string? search = null);
        Medicine GetById(int id);
        void Add(Medicine medicine);
        void Update(Medicine medicine);
        void Delete(int id);
        void Save();
    }
}
