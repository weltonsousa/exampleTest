using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using System.Threading.Tasks;
using Examples.Charge.Domain.Aggregates.PersonAggregate;

namespace Examples.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonPhonesController : BaseController
    {
        private IPersonPhoneFacade _facade;
        private IMapper _mapper;

        public PersonPhonesController(IPersonPhoneFacade facade, IMapper mapper)
        {
            _facade = facade;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("/api/personphones")]
        public async Task<ActionResult<PersonPhoneListResponse>> Get() => Response(await _facade.FindAllAsync());

        [HttpGet]
        [Route("/api/personphones/get/{id}")]
        public async Task<ActionResult> Get(string name)
        {
            var personPhone = await _facade.Get(name);

            if (personPhone == null)
            {
                return NotFound();
            }

            return Ok(personPhone);
        }

        [HttpPost]
        [Route("/api/personphones/create")]
        public async Task<IActionResult> Create([FromBody] PersonPhone personPhone)
        {
            var personPhoneCreate = await _facade.Create(personPhone);
            return Ok(personPhoneCreate);
        }

        [HttpDelete]
        [Route("/api/persophones/remove/{id}")]
        public async Task<IActionResult> Remove(string id)
        {
            await _facade.Remove(id);
            return Ok();
        }
    }
}
