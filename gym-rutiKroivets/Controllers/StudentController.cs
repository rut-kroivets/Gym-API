using AutoMapper;
using Gym.Core.DTOs;
using Gym.Core.Service;
using Gym.Service;
using gym_rutiKroivets.Entities;
using gym_rutiKroivets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gym_rutiKroivets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public StudentController(IStudentService context, IMapper mapper)
        {
            _studentService = context;
            _mapper = mapper;
        }
    
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> Get()
        {
            var list = await _studentService.GetAsync();
            var listDto = _mapper.Map<IEnumerable<StudentDto>>(list);
            return Ok(listDto);
        }
        // GET: api/<ValuesController>
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> Get(int id)
        {
            var student = await _studentService.GetAsync(id);
            var studentDto = _mapper.Map<StudentDto>(student);
            return Ok(studentDto);

        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult<Student>> Post([FromBody] StudentPostModel s)
        {
            var studentToAdd = _mapper.Map<Student>(s);
            await _studentService.PostAsync(studentToAdd);
            var studentDto = _mapper.Map<StudentDto>(studentToAdd);
            return Ok(studentDto);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] StudentPostModel s)
        {
            Student existStudent = await _studentService.GetAsync(id);
            if (existStudent is null)
            {
                return NotFound();
            }
            _mapper.Map(s, existStudent);

            await _studentService.PutAsync(id, existStudent);

            return Ok(_mapper.Map<StudentDto>(existStudent));
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _studentService.DeleteAsync(id);
        }
    }
}
