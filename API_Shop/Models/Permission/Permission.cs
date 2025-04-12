using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Shop.Models.Permission
{
    public class Permission
    {
        [Key]
        public int PermissionId { get; set; }
        public string PermissionTitle { get; set; }
        public int? ParentId { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(ParentId))]
        public ICollection<Permission>? Permissions { get; set; }

        [JsonIgnore]
        public ICollection<RolePermission>? RolePermissions { get; set; }
    }
}
