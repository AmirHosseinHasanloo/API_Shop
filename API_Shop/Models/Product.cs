using System.ComponentModel.DataAnnotations.Schema;

namespace API_Shop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        // navigation properties
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
    }
}
