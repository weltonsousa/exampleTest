
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Interfaces
{
    public interface IPersonPhoneFacade
    {
        Task<PersonPhoneListResponse> FindAllAsync();
        Task<PersonPhone> Create(PersonPhone personPhone);
        Task<PersonPhone> Update(PersonPhone personPhone);
        Task<PersonPhone> Remove(string id);       
        Task<PersonPhone> Get(string name);
    }
}
