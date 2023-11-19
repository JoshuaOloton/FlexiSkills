using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Export")]
    public partial class Export
    {
        [Column("S/N")]
        [StringLength(255)]
        public string? SN { get; set; }
        [StringLength(255)]
        public string? Matricnum { get; set; }
        [StringLength(255)]
        public string? Surname { get; set; }
        [StringLength(255)]
        public string? Firstname { get; set; }
        [StringLength(255)]
        public string? Othername { get; set; }
        [StringLength(255)]
        public string? Program { get; set; }
        [StringLength(255)]
        public string? Level { get; set; }
        [StringLength(255)]
        public string? Session { get; set; }
        [StringLength(255)]
        public string? Bank { get; set; }
        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }
        [Column("ReceiptNo.")]
        [StringLength(255)]
        public string? ReceiptNo { get; set; }
        [StringLength(255)]
        public string? Date { get; set; }
        [StringLength(255)]
        public string? Phone { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string? Appnum { get; set; }
    }
}
