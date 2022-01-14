using Examples.Charge.Domain.Aggregates.ExampleAggregate.Interfaces;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.ExampleAggregate
{
    public class PersonPhoneService : IPersonPhoneService
    {
        private IPersonPhoneRepository _exampleService;
        public PersonPhoneService(IPersonPhoneRepository exampleService)
        {
            _exampleService = exampleService;
        }

        public async Task<List<PersonPhone>> FindAllAsync() => (await _exampleService.FindAllAsync()).ToList();
    }
}
