using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_TestTechnique.Models
{
    [Table("Candidat",Schema ="HR")]
    public class Candidat
    {
        [Key]
        [Display(Name ="Id")]
        public int CandidatId { get; set; }
        [Required]
        [Display(Name = "Prénom")]
        [Column(TypeName ="varchar(20)")]
        public string Firstname { get; set; }
        [Required]
        [Display(Name = "Nom")]
        [Column(TypeName = "varchar(20)")]
        public string Lastname { get; set; }
        [Required]
        [Display(Name = "Mail")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Téléphone")]
        [MinLength(10)]
        [MaxLength(10)]
        [Column(TypeName ="varchar(10)")]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "Niveau d’étude")]
        [Column(TypeName = "varchar(50)")]
        public string ScooleLevel { get; set; }
        [Required]
        [Display(Name = "Nombre d’années d’expérience")]
        [Column(TypeName = "varchar(50)")]
        public string Experience { get; set; }
        [Required]
        [Display(Name = "Dernier employeur")]
        [Column(TypeName = "varchar(50)")]
        public string LastJob { get; set; }

        [Display(Name = "cv du candidat")]
        [Column(TypeName = "varchar(250)")]
        public string CandidatCv { get; set; }
    }
}
