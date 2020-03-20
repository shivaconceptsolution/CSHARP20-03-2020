using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproach
{
    class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Rno { get; set; }
        public string Sname { get; set; }
        public string Branch { get; set; }
        public string Fees { get; set; }
        public int CourseCourseId { get; set; }
        public string Semester { get; set; }
        public string Mobile { get; set; }
    }
}
