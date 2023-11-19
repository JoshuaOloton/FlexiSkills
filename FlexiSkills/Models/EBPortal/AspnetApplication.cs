using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("aspnet_Applications")]
    [Index("LoweredApplicationName", Name = "UQ__aspnet_A__17477DE40425A276", IsUnique = true)]
    [Index("ApplicationName", Name = "UQ__aspnet_A__3091033107020F21", IsUnique = true)]
    public partial class AspnetApplication
    {
        public AspnetApplication()
        {
            AspnetMemberships = new HashSet<AspnetMembership>();
            AspnetPaths = new HashSet<AspnetPath>();
            AspnetRoles = new HashSet<AspnetRole>();
            AspnetUsers = new HashSet<AspnetUser>();
        }

        [StringLength(256)]
        public string ApplicationName { get; set; } = null!;
        [StringLength(256)]
        public string LoweredApplicationName { get; set; } = null!;
        [Key]
        public Guid ApplicationId { get; set; }
        [StringLength(256)]
        public string? Description { get; set; }

        [InverseProperty("Application")]
        public virtual ICollection<AspnetMembership> AspnetMemberships { get; set; }
        [InverseProperty("Application")]
        public virtual ICollection<AspnetPath> AspnetPaths { get; set; }
        [InverseProperty("Application")]
        public virtual ICollection<AspnetRole> AspnetRoles { get; set; }
        [InverseProperty("Application")]
        public virtual ICollection<AspnetUser> AspnetUsers { get; set; }
    }
}
