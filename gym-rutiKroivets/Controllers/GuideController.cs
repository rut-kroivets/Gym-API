using AutoMapper;
using Gym.Core.DTOs;
using Gym.Core.Service;
using gym_rutiKroivets.Entities;
using gym_rutiKroivets.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gym_rutiKroivets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuideController : ControllerBase
    {
        private readonly IGuideService _guideService;
        private readonly IMapper _mapper;
        public GuideController(IGuideService guideService, IMapper mapper)
        {
            _guideService = guideService;
            _mapper = mapper;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult<IEnumerable<Guide>> Get()
        {
            var list = _guideService.Get();
            var listDto = _mapper.Map<IEnumerable<GuideDto>>(list);
            return Ok(listDto);
        }
        // GET: api/<ValuesController>
        [HttpGet("{id}")]
        public ActionResult<Guide> Get(int id)
        {
            var guide= _guideService.Get(id);
            var guideDto = _mapper.Map<GuideDto>(guide);
            return Ok(guideDto);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult<Guide>> Post([FromBody] GuidePostModel g)
        {      
            var guideToAdd = _mapper.Map<Guide>(g);
            await _guideService.PostAsync(guideToAdd);
            var guideDto = _mapper.Map<GuideDto>(guideToAdd);
            return Ok(guideDto);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] GuidePostModel g)
        {
            ActionResult<Guide> existGuide = _guideService.Get(id);

            if (existGuide.Value is null)
            {
                return NotFound();
            }
            _mapper.Map(g, existGuide);

            await _guideService.PutAsync(id,existGuide.Value);

            return Ok(_mapper.Map<GuideDto>(existGuide));
        }

        //DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
             await _guideService.DeleteAsync(id);
        }
    }
}
