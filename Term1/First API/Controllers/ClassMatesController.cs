using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace First_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClassMatesController : ControllerBase
    {
        private static readonly string[] Names = new[]
        {
            "Jack", "Vaughn", "Jeremy", "Declan", "Gary", "Jacob", "Tyler", "Rueben", "Femi", "Lyell"
        };

        private static readonly string[] Levels = new[]
        {
            "Good", "God Like", "Bad", "Terrible", "Average"
        };


        private readonly ILogger<ClassMatesController> _logger;

        public ClassMatesController(ILogger<ClassMatesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ClassMates> Get()
        {
            var rng = new Random();
            ClassMates[] people = { };
            foreach (string name in Names)
            {
                Array.Resize(ref people, people.Length + 1);


                ClassMates newClassMate = new ClassMates(Levels[rng.Next(0, 5)], name, rng.Next(18, 22));
                people[people.Length - 1] = newClassMate;
            }

            return people;
        }

    }
}