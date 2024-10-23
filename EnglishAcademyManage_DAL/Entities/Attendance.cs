namespace EnglishAcademyManage_DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Attendance")]
    public partial class Attendance
    {
        [Key]
        public int attendance_id { get; set; }

        [Required]
        [StringLength(10)]
        public string student_id { get; set; }

        [Required]
        [StringLength(10)]
        public string class_id { get; set; }

        public DateTime attendance_date { get; set; }

        [Required]
        [StringLength(20)]
        public string status { get; set; }

        public virtual Class Class { get; set; }

        public virtual Student Student { get; set; }
    }
}
