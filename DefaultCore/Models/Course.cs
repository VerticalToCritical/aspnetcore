using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DefaultCore.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int CourseId { get; set; }

        public string Title { get; set; }
        public int Credit { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
