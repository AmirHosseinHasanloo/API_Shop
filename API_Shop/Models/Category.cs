namespace API_Shop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // navigation properties
        public ICollection<Product>? Products { get; set; }
    }
}
