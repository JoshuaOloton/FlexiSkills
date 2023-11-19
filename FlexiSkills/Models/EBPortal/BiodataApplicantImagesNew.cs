using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("BiodataApplicantImages_NEW")]
    public partial class BiodataApplicantImagesNew
    {
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        public byte[] ImgData { get; set; } = null!;
        public byte[]? BioImgData { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Progtype { get; set; } = null!;
    }
}
