using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ARMS.Models
{
    public class PhoneNumber
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Display(Name = "Phone Number")]
        [Column("phone_number")]
        public string Number { get; set; }
    }
}