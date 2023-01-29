using Core.Entities;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public bool Status { get; set; }
        public virtual Category? Category { get; set; }
    }
}
