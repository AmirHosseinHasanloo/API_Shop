using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using API_Shop.Models.Permission;

namespace API_Shop.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Display(Name = "نقش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "فیلد {0} نمی تواند بیش از {1} کاراکتر باشد.")]
        public string RoleTitle { get; set; }

        public bool IsDelete { get; set; }

        [JsonIgnore]
        public ICollection<UserRole>? UserRoles { get; set; }
        [JsonIgnore]
        public ICollection<RolePermission>? RolePermissions { get; set; }
    }
}
