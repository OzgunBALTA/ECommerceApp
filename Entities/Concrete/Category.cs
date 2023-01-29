using Core.Entities;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public bool Status { get; set; }
        public virtual List<Product>? Products { get; set; }
    }
}
