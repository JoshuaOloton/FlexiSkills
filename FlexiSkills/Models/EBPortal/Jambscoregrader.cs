using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Jambscoregrader")]
    public partial class Jambscoregrader
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("lowerlimit")]
        public int Lowerlimit { get; set; }
        [Column("upperlimit")]
        public int Upperlimit { get; set; }
        [Column("grade")]
        public int Grade { get; set; }
    }
}
