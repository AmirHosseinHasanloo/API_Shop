using System.Text.Json.Serialization;

namespace API_Shop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // navigation properties
        [JsonIgnore]
        public ICollection<Product>? Products { get; set; }
    }
}
