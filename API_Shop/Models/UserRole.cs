using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Shop.Models
{
    public class UserRole
    {
        [Key]
        public int UR_Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

        // navigation properties
        [JsonIgnore]
        [ForeignKey(nameof(UserId))]
        public User? User { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(RoleId))]
        public Role? Role { get; set; }
    }
}
