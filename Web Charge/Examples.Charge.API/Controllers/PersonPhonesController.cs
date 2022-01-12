using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using System.Threading.Tasks;
using System;

namespace Examples.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonPhonesController : BaseController
    {
        private IPersonPhoneFacade _facade;

        public PersonPhonesController(IPersonPhoneFacade facade, IMapper mapper)
        {
            _facade = facade;
        }

        [HttpGet]
        public async Task<ActionResult<PersonPhoneListResponse>> Get() => Response(await _facade.FindAllAsync());

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return Response(400);
            }

             await _facade.Update(id);
            return Response(200);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                await _facade.Delete(id);
                return Response(200);
            }
            catch (Exception)
            {

            }

            return (null);
        }
    }
}
