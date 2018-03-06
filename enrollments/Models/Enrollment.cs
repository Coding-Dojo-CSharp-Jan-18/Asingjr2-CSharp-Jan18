using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace enrollments.Models
{
    public class Enrollment
    {
        [Key]
        public int enrollment_id {get;set;}
        public DateTime start_date {get;set;}
        public DateTime end_date {get;set;}
        public int student_id {get;set;}
        public int course_id {get;set;}

        public Student EnrolledStudent {get;set;}
        public Course Session {get;set;}
    }
}