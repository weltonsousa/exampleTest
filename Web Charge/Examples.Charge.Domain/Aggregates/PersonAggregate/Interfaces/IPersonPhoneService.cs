using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonPhoneService
    {
        Task<List<PersonPhone>> FindAllAsync();
        Task<PersonPhone> Create(PersonPhone personPhone);
        Task<PersonPhone> Get(string name);
        Task<PersonPhone> Remove(string id);
        Task<PersonPhone> Update(PersonPhone personPhone);
    }
}
