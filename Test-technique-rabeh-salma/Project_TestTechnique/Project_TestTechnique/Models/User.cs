using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_TestTechnique.Models
{
    [Table("User",Schema ="HR")]
    public class User
    {
        [Key]
        [Display(Name ="ID")]
        public int UserId { get; set; }

        [Required]
        [Display(Name = "Mail")]
        [DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; }

        [Required]
        [Display(Name ="Mot de pass")]
        [DataType(DataType.Password)]
        public string UserPasswored { get; set; }
    }
}
