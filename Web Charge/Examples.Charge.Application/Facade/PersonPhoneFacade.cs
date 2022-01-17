using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.ExampleAggregate.Interfaces;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Facade
{
    public class PersonPhoneFacade : IPersonPhoneFacade
    {
        private IPersonPhoneService _personPhoneService;
        private IMapper _mapper;

        public PersonPhoneFacade(IPersonPhoneService personPhoneService, IMapper mapper)
        {
            _personPhoneService = personPhoneService;
            _mapper = mapper;
        }

        public async Task<PersonPhone> Create(PersonPhone personPhone)
        {
            var personPhoneCreated = await _personPhoneService.Create(personPhone);
            return personPhoneCreated;
        }

        public async Task<PersonPhoneListResponse> FindAllAsync()
        {
            var result = await _personPhoneService.FindAllAsync();
            var response = new PersonPhoneListResponse();
            response.Objects = new List<PersonPhoneDto>();
            response.Objects.AddRange(result.Select(x => _mapper.Map<PersonPhoneDto>(x)));
            return response;
        }

        public async Task<PersonPhone> Get(string name)
        {
            var personPhone = await _personPhoneService.Get(name);
            return personPhone;
        }

        public async Task<PersonPhone> Remove(string id)
        {
            var result = await _personPhoneService.Remove(id);
            return result;
        }

        public async Task<PersonPhone> Update(PersonPhone personPhone)
        {
            var personPhoneUpdated = await _personPhoneService.Update(personPhone);
            return personPhoneUpdated;
        }


    }
}
