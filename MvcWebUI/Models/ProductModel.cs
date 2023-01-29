namespace MvcWebUI.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public bool Status { get; set; }
    }
}
