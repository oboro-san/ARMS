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
        [Column("mat_number")]
        public string MatNumber { get; set; }

        [MaxLength(50)]
        [Display(Name = "Reg. Number")]
        [Column("reg_number")]
        public string RegNumber { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Lastname")]
        [Column("lastname")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Firstname")]
        [Column("firstname")]
        public string FirstName { get; set; }

        [MaxLength(150)]
        [Display(Name = "Middle Name")]
        [Column("middlename")]
        public string MiddleName { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("gender")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [Column("dob")]
        public DateTime Dob { get; set; }

        [Required]
        [Display(Name = "Nationality")]
        [Column("nationality_id")]
        public int NationalityId { get; set; }

        [Display(Name = "State")]
        [Column("state_id")]
        public int StateId { get; set; }

        [Display(Name = "Local Govt. Area")]
        [Column("lga_id")]
        public int LgaId { get; set; }

        public List<Address> Addresses { get; set; } = new List<Address>();

        public List<Email> EmailAddresses { get; set; } = new List<Email>();

        public List<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();

        public List<NextOfKin> NextOfKins { get; set; } = new List<NextOfKin>();
    }
}