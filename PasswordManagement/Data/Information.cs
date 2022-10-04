using System.ComponentModel.DataAnnotations;

namespace PasswordManagement.Data
{
    public class Information
    {
        [Required, MaxLength(200)]
        public string Name { get; set; }
        [Required, MaxLength(300)]
        public string URL { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required, MaxLength(100)]
        public string Password { get; set; }
    }
}
