using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("mobileNotification")]
    public partial class MobileNotification
    {
        [Key]
        [Column("MessageID")]
        public int MessageId { get; set; }
        [Column("title")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Title { get; set; }
        [Column("msg", TypeName = "text")]
        public string? Msg { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("dateUploaded")]
        [StringLength(50)]
        [Unicode(false)]
        public string? DateUploaded { get; set; }
    }
}
