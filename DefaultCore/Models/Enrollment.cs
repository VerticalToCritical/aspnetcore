using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DefaultCore.Models
{
    public enum Grade
    {
        A,
        B,
        C,
        D,
        E,
        F
    }

    public class Enrollment
    {
        [Key]
        public int EntrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Grade? Grade { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
