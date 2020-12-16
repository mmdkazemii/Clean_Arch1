using CleanArch.Data.Context;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArch.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        UniversityDbContext _ctx;
        public CourseRepository(UniversityDbContext Context)
        {
            _ctx = Context;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses.ToList();
        }
    }
}
