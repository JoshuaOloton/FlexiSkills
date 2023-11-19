using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("hostelclearancelog")]
    public partial class Hostelclearancelog
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? ClearanceOfficerUsername { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? ClearanceOfficerName { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? ClearedStudent { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? StudentAppNum { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? AllotedHostel { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? ClearanceStatus { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? ClearanceDate { get; set; }
    }
}
