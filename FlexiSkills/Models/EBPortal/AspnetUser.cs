﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("aspnet_Users")]
    [Index("ApplicationId", "LastActivityDate", Name = "aspnet_Users_Index2")]
    public partial class AspnetUser
    {
        public AspnetUser()
        {
            AspnetPersonalizationPerUsers = new HashSet<AspnetPersonalizationPerUser>();
            Roles = new HashSet<AspnetRole>();
        }

        public Guid ApplicationId { get; set; }
        [Key]
        public Guid UserId { get; set; }
        [StringLength(256)]
        public string UserName { get; set; } = null!;
        [StringLength(256)]
        public string LoweredUserName { get; set; } = null!;
        [StringLength(16)]
        public string? MobileAlias { get; set; }
        public bool IsAnonymous { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime LastActivityDate { get; set; }

        [ForeignKey("ApplicationId")]
        [InverseProperty("AspnetUsers")]
        public virtual AspnetApplication Application { get; set; } = null!;
        [InverseProperty("User")]
        public virtual AspnetMembership AspnetMembership { get; set; } = null!;
        [InverseProperty("User")]
        public virtual AspnetProfile AspnetProfile { get; set; } = null!;
        [InverseProperty("User")]
        public virtual ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Users")]
        public virtual ICollection<AspnetRole> Roles { get; set; }
    }
}
