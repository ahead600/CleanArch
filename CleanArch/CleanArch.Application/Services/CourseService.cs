using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseServiceRepository;           
            
        public CourseService(ICourseRepository courseRepository)
        {
            _courseServiceRepository = courseRepository;
        }

        public CoursesViewModel GetCourses()
        {
            return new CoursesViewModel()
            {
                Courses = _courseServiceRepository.GetCourses()
            };
        }
    }
}
