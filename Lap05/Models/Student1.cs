namespace Lap05.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student1
    {
        [Key]
        [StringLength(20)]
        public string StudentID { get; set; }

        [Required]
        [StringLength(200)]
        public string FullName { get; set; }

        public double AverageScore { get; set; }

        public int FacultyID { get; set; }

        public virtual Faculty1 Faculty1 { get; set; }
    }
}
