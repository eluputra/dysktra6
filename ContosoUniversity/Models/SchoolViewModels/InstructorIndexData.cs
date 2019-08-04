using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// added the new index data for instructor 
// created intructor index data as what the tutorial wanted

namespace ContosoUniversity.Models.SchoolViewModels
{
    public class InstructorIndexData
    {
        public IEnumerable<Instructor> Instructors { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}