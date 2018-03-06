using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace enrollments.Models
{
    public class Course
    {
        [Key]
        public int course_id {get;set;}
        public string title {get;set;}
        public string instructor {get;set;}
        public List<Enrollment> EnrolledStudents {get;set;}

    }
}