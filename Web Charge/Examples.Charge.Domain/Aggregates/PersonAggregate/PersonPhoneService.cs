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

        public async Task<PersonPhone> Add()
        {
            await _personPhoneRepository.Add();

            return (null);
        }

        public async Task<PersonPhone> Delete(int? id)
        {
            await _personPhoneRepository.Delete(id);

            return (null);
        }

        public async Task<List<PersonPhone>> FindAllAsync() => (await _personPhoneRepository.FindAllAsync()).ToList();
       

        public async Task<PersonPhone> Update(int? id)
        {
            await _personPhoneRepository.Update(id);

            return (null);
        }
    }
}
