using Microsoft.AspNetCore.Mvc;
using StudentRecordManager.Models;
using StudentRecordManager.Services;

namespace StudentRecordManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly StudentService _service;

        public StudentsController(StudentService service)
        {
            _service = service;
        }

        // GET ALL
        [HttpGet]
        public async Task<List<Student>> Get() =>
            await _service.Get();

        // GET BY ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> Get(string id)
        {
            var student = await _service.Get(id);
            if (student == null) return NotFound();
            return student;
        }
        // Create
        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            await _service.Create(student);
            return Ok(student);
        }

        // UPDATE
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Student student)
        {
            await _service.Update(id, student);
            return NoContent();
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _service.Delete(id);
            return NoContent();
        }
        }
        }
        