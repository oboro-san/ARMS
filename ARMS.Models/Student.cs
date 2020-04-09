using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ARMS.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [MaxLength(50)]
        [Column("student_id")]
        public string StudentId { get; set; }

        [MaxLength(50)]
        [Display(Name = "Mat. Number")]
        [Column("matric_number")]
        public string MatNumber { get; set; }

        [MaxLength(50)]
        [Display(Name = "Reg. Number")]
        [Column("reg_number")]
        public string RegNumber { get; set; }

        [MaxLength(150)]
        [Display(Name = "Lastname")]
        [Column("lastname")]
        public string LastName { get; set; }

        [MaxLength(150)]
        [Display(Name = "Firstname")]
        [Column("firstname")]
        public string FirstName { get; set; }

        [MaxLength(150)]
        [Display(Name = "Middle Name")]
        [Column("middlename")]
        public string MiddleName { get; set; }

        [MaxLength(50)]
        [Column("sex")]
        public string Sex { get; set; }

        [Display(Name = "Nationality")]
        [MaxLength(50)]
        [Column("nationality")]
        public string Nationality { get; set; }

        [Display(Name = "Local Govt. Area")]
        [MaxLength(50)]
        [Column("lga")]
        public string Lga { get; set; }

        [Display(Name = "Marital Status")]
        [MaxLength(50)]
        [Column("marital_status")]
        public string MaritalStatus { get; set; }

        [Display(Name = "Certificate Code")]
        [MaxLength(50)]
        [Column("certcode")]
        public string CertCode { get; set; }

        [Display(Name = "Level")]
        [MaxLength(50)]
        [Column("current_level")]
        public string CurrentLevel { get; set; }

        [Display(Name = "Session")]
        [MaxLength(50)]
        [Column("current_session")]
        public string CurrentSession { get; set; }

        [Display(Name = "Full Name")]
        [MaxLength(250)]
        [Column("fullname")]
        public string FullName { get; set; }
    }
}