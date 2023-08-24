using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Westcoast_education_cicd.Entities;

namespace Westcoast_education_cicd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly List<Course> courses = new List<Course>
        {
            new Course {Id = 1, Name = "Math" },
            new Course {Id = 2, Name = "English" },
            new Course {Id = 3, Name = "Science" },
            new Course {Id = 4, Name = "Biology" },
            new Course {Id = 5, Name = "Computer Science" },
            new Course {Id = 6, Name = "History" }
        };
        [HttpGet]
        public ActionResult<IEnumerable<Course>> Get()
        {
            return courses;
        }
    }
}