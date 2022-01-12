
using Examples.Charge.Application.Messages.Response;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Interfaces
{
    public interface IPersonPhoneFacade
    {
        Task<PersonPhoneListResponse> FindAllAsync();

        Task<PersonPhoneListResponse> Add();
        Task<PersonPhoneListResponse> Update(int? id);
        Task<PersonPhoneListResponse> Delete(int? id);
        Task<PersonPhoneListResponse> GetEntityById(int? Id);
       
    }
}
