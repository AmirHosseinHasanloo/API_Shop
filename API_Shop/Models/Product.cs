using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Shop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public bool IsExists { get; set; }

        // navigation properties
        [ForeignKey(nameof(CategoryId))]
        [JsonIgnore]
        public Category? Category { get; set; }
    }
}
