using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagement.DataModel
{
    public class PasswordModel
    {
        public int Id { get; set; }
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
