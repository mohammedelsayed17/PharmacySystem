namespace PharmacySystem.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int MedicineId { get; set; }
        public int Quantity { get; set; }

        public Medicine Medicine { get; set; }
    }
}
