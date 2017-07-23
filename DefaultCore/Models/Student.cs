using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DefaultCore.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Firstname { get; set; }

        public string Lastname { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
