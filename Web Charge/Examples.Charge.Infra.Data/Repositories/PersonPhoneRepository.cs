using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PersonPhoneRepository : IPersonPhoneRepository
    {
        private readonly ExampleContext _context;

        public PersonPhoneRepository(ExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        public async Task<PersonPhone> Create(PersonPhone personPhone)        {

            _context.Add(personPhone);
            await _context.SaveChangesAsync();
            return personPhone;
        }       

        public virtual async Task<PersonPhone> Update(PersonPhone obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return obj;
        }

        public virtual async Task<PersonPhone> Remove(string id)
        {
            var obj = await Get(id);

            if (obj != null)
            {
                _context.Remove(obj);
                await _context.SaveChangesAsync();
            }

            return obj;
        }

        public virtual async Task<PersonPhone> Get(string name)
        {
            var obj = await _context.Set<PersonPhone>()
                    .AsNoTracking()
                    .Where(x => x.PhoneNumber == name)
                    .ToListAsync();

            return obj.FirstOrDefault();
        }

        public async Task<IEnumerable<PersonPhone>> FindAllAsync() => await Task.Run(() => _context.PersonPhone);       
    }
}
