using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("screeningLock")]
    public partial class ScreeningLock
    {
        [Column("RegLockID")]
        public int RegLockId { get; set; }
        public int LockStatus { get; set; }
        [Column("message", TypeName = "ntext")]
        public string Message { get; set; } = null!;
        [Column("programTypeID")]
        public int ProgramTypeId { get; set; }
        public int RegistrationStatus { get; set; }
        [Column("dateModified")]
        public DateTime DateModified { get; set; }
        [Column("who")]
        [StringLength(50)]
        [Unicode(false)]
        public string Who { get; set; } = null!;
        public int? PaymentStatus { get; set; }
        public int? DocketStatus { get; set; }
    }
}
