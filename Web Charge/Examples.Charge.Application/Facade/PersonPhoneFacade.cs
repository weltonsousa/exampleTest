using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.ExampleAggregate.Interfaces;
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

        public async Task<PersonPhoneListResponse> Add()
        {
            var create = await _personPhoneService.Add();
            var response = new PersonPhoneListResponse();
            response.Objects = new List<PersonPhoneDto>();

            response.Objects.Select(x => _mapper.Map<PersonPhoneDto>(x));

            return response;
            
        }

        public async Task<PersonPhoneListResponse> Delete(int? id)
        {
            var remove = await _personPhoneService.Delete(id);

            var response = new PersonPhoneListResponse();

            return response;

        }

        public async Task<PersonPhoneListResponse> FindAllAsync()
        {
            var result = await _personPhoneService.FindAllAsync();
            var response = new PersonPhoneListResponse();
            response.Objects = new List<PersonPhoneDto>();
            response.Objects.AddRange(result.Select(x => _mapper.Map<PersonPhoneDto>(x)));
            return response;
        }

        public async Task<PersonPhoneListResponse> GetEntityById(int? Id)
        {
            var result = await _personPhoneService.GetEntityById(Id);
            var response = new PersonPhoneListResponse();
            response.Objects = new List<PersonPhoneDto>();
            response.Objects.AddRange(result.Select(x => _mapper.Map<PersonPhoneDto>(x)));
            return response;
        }

        public async Task<PersonPhoneListResponse> Update(int? id)
        {
            var up = await _personPhoneService.Update(id);

            var response = new PersonPhoneListResponse();

            return response;
        }
    }
}
