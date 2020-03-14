using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ARMS.Models
{
    public class Email
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(400)]
        [Display(Name = "Email Address")]
        [Column("email_address")]
        public string EmailAddress { get; set; }

        [MaxLength(50)]
        [Column("student_id")]
        public string StudentId { get; set; }

        [Column("next_of_kin_id")]
        public int NextOfKinId { get; set; }
    }
}