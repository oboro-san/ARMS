using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ARMS.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(350)]
        [Display(Name = "Street Name")]
        [Column("street")]
        public string Street { get; set; }

        [MaxLength(50)]
        [Column("city")]
        public string City { get; set; }

        [MaxLength(50)]
        [Column("state")]
        public string State { get; set; }

        [MaxLength(50)]
        [Column("country")]
        public string Country { get; set; }

        [MaxLength(50)]
        [Column("zipcode")]
        public string ZipCode { get; set; }

        [MaxLength(50)]
        [Column("student_id")]
        public string StudentId { get; set; }

        [Column("next_of_kin_id")]
        public int NextOfKinId { get; set; }
    }
}