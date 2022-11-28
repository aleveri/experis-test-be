using Experis_BE_Domain.Entities;
using Experis_BE_Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Experis_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : BaseController<Student>
    {
        public StudentController(IBaseService<Student> service) : base(service)
        {
        }
    }
}
