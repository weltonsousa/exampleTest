using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate
{
    public class PersonPhoneService : IPersonPhoneService
    {
        private readonly IPersonPhoneRepository _personPhoneRepository;
       
        public PersonPhoneService(IPersonPhoneRepository personPhoneRepository)
        {
            _personPhoneRepository = personPhoneRepository;         
        }

        public async Task<List<PersonPhone>> FindAllAsync() => (await _personPhoneRepository.FindAllAsync()).ToList();


        public async Task<PersonPhone> Create(PersonPhone personPhone)
        {     
            var personCreated = await _personPhoneRepository.Create(personPhone);
            return personCreated;
        }

        public async Task<PersonPhone> Update(PersonPhone personPhone)
        {
            var personUpdated = await _personPhoneRepository.Update(personPhone);
            return personUpdated;
        }

        public async Task<PersonPhone> Remove(string id)
        {
           var result = await _personPhoneRepository.Remove(id);

            return result;
        }
        
        public async Task<PersonPhone> Get(string name)
        {
          var obter = await _personPhoneRepository.Get(name);

            return obter;
        }




    }
}
