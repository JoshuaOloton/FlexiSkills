using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Images_bsc")]
    public partial class ImagesBsc
    {
        [Column("Image_temp_Bsc")]
        public byte[]? ImageTempBsc { get; set; }
    }
}
