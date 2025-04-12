using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Shop.Models.Permission
{
    public class RolePermission
    {
        [Key]
        public int RP_Id { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(RoleId))]
        public Role? Role { get; set; }

        [JsonIgnore]
        public Permission? Permission { get; set; }
    }
}
