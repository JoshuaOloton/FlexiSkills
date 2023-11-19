using System.ComponentModel.DataAnnotations;

namespace FlexiSkills.FormModels
{
    public class Login
    {
        [Required]
        [DataType(DataType.Text)]
        public String MatricNo { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }
    }
}
