using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ARMS.Models
{
    public class NextOfKin
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Column("title")]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Lastname")]
        [Column("lastname")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Firstname")]
        [Column("firstname")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("relationship")]
        public string Relationship { get; set; }

        [MaxLength(50)]
        [Column("student_id")]
        public string StudentId { get; set; }

        public List<Address> Addresses { get; set; } = new List<Address>();

        public List<Email> EmailAddresses { get; set; } = new List<Email>();

        public List<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();
    }
}