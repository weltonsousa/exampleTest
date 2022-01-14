using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.ExampleAggregate.Interfaces
{
    public interface IPersonPhoneRepository
    {
        Task<IEnumerable<PersonPhone>> FindAllAsync();
       
            Task CreateAsync(PersonPhone obj);
            Task UpdateAsync(PersonPhone obj);
            Task RemoveAsync(long id);
            Task<List<PersonPhone>> GetAllAsync();
            Task<PersonPhone> GetAsync(long id);
          
        }
}
