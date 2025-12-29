using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JumpArena.Models
{
    [Table("VaiTro")]
    public class Role
    {
        [Key]
        public int RoleID { get; set; } // VaiTroID

        [Required]
        [StringLength(50)]
        public string RoleName { get; set; } // TenVaiTro

        public virtual ICollection<User> Users { get; set; }
    }
}