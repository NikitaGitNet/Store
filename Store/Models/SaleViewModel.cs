namespace Store.WEB.Models
{
    public class SaleViewModel
    {
        public Guid Id { get; set; }
        public string? EmployeeName { get; set; }
        public string? ProductName { get; set; }
        public Guid ProductId { get; set; }
        public string? TitleImagePath { get; set; }
        public float Price { get; set; }
        public DateTime DateOfSale { get; set; }
    }
}
