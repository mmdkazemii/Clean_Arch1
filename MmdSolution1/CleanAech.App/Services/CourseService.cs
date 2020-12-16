using CleanAech.App.Intefaces;
using CleanAech.App.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanAech.App.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        
        public CourseViewModel GetCourses()
        {
            CourseViewModel Cvm = new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
            return Cvm;
        }
    }
}
