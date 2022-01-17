using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonPhoneRepository
    {
        Task<IEnumerable<PersonAggregate.PersonPhone>> FindAllAsync();
        Task<PersonPhone> Create(PersonPhone personPhone);
        Task<PersonPhone> Update(PersonPhone personPhone);
        Task<PersonPhone> Remove(string id);   
        Task<PersonPhone> Get(string name);        
    }
}
