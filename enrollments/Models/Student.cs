using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace enrollments.Models
{
    public class Student
    {
        [Key]
        public int student_id {get;set;}
        public string first_name {get;set;}
        public string last_name {get;set;}
        public List<Enrollment> EnrolledCourses {get;set;}
    }
}