using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class PostutmeBatch
    {
        public PostutmeBatch()
        {
            PostutmeAllocations = new HashSet<PostutmeAllocation>();
            PostutmeAllocationsCopies = new HashSet<PostutmeAllocationsCopy>();
        }

        [Key]
        [Column("BatchID")]
        [StringLength(50)]
        [Unicode(false)]
        public string BatchId { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string Day { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string ExamDate { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string Session { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string ExamTime { get; set; } = null!;

        [InverseProperty("Batch")]
        public virtual ICollection<PostutmeAllocation> PostutmeAllocations { get; set; }
        [InverseProperty("Batch")]
        public virtual ICollection<PostutmeAllocationsCopy> PostutmeAllocationsCopies { get; set; }
    }
}
