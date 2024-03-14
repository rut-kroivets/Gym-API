using AutoMapper;
using Gym.Core.DTOs;
using Gym.Core.Service;
using Gym.Service;
using gym_rutiKroivets.Entities;
using gym_rutiKroivets.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gym_rutiKroivets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingService _trainingService;
        private readonly IMapper _mapper;
        public TrainingController(ITrainingService context, IMapper mapper)
        {
            _trainingService = context;
            _mapper = mapper;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult<IEnumerable<Training>> Get()
        {
            var list = _trainingService.Get();
            var listDto = _mapper.Map<IEnumerable<TrainingDto>>(list);
            return Ok(listDto);
        }
        // GET: api/<ValuesController>
        [HttpGet("{id}/Day")]
        public ActionResult<Training> Get([FromBody]  int id)
        {
            var training = _trainingService.Get(id);
            var trainingDto = _mapper.Map<TrainingDto>(training);
            return Ok(trainingDto);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult<Training>> Post([FromBody] TrainingPostModel t)
        {
            var trainingToAdd = _mapper.Map<Training>(t);
            await _trainingService.PostAsync(trainingToAdd);
            var trainingDto = _mapper.Map<TrainingDto>(trainingToAdd);
            return Ok(trainingDto);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] TrainingPostModel t)
        {
            ActionResult<Training> existTraining = _trainingService.Get(id);
            if (existTraining.Value is null)
            {
                return NotFound();
            }
            _mapper.Map(t, existTraining);

            await _trainingService.PutAsync(id, existTraining.Value);

            return Ok(new ActionResult<TrainingDto>(_mapper.Map<TrainingDto>(existTraining)));

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
           await _trainingService.DeleteAsync(id);
        }
    }
}
