namespace Store.WEB.Models
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? TitleImagePath { get; set; }
        public string? BrandName { get; set; }
        public decimal? Price { get; set; }
    }
}
