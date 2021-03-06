﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using enrollments.Models;

namespace HelloEF.Controllers
{
    public class HomeController : Controller
    {
        private SchoolContext _context;
        public HomeController(SchoolContext context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet("students")]
        public IActionResult Students()
        {
            var students = _context.students
                .Include(s => s.EnrolledCourses)
                .ThenInclude(e => e.Session)
                .ToList();

            return View(students);
        }

        [HttpGet("courses")]
        public IActionResult Courses()
        {
            var courses = _context.courses
                .ToList();

            // students are currently enrolled in python


            return View(courses);
        }

        [HttpGet("python")]
        public IActionResult Python()
        {
            List<Student> currentPythonStudents = _context.courses
                .Include(c => c.EnrolledStudents)
                    .ThenInclude(e => e.EnrolledStudent)
                // in python
                .FirstOrDefault(c => c.title == "Python")
                // currently
                .EnrolledStudents.Where(e => e.start_date < DateTime.Now && e.end_date > DateTime.Now)
                .Select(e => e.EnrolledStudent).ToList();
            return View(currentPythonStudents);
        }

        [HttpGet("devon")]
        public IActionResult Devon()
        {
            List<Student> allDevonsStudentsPastAndPresent = _context.courses
                .Include(c => c.EnrolledStudents)
                    .ThenInclude(e => e.EnrolledStudent)
                .Where(c => c.instructor == "Devon")
                .SelectMany(c => c.EnrolledStudents)
                    .Select(e => e.EnrolledStudent).ToList();
            return View(allDevonsStudentsPastAndPresent);
        }


        [HttpPost("enrollments/create")]
        public IActionResult CreateEnrollment(Enrollment en)
        {
            if (ModelState.IsValid)
            {
                // add student to course
                _context.enrollments.Add(en);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}