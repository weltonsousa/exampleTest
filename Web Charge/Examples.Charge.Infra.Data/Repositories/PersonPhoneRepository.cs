using Examples.Charge.Domain.Aggregates.ExampleAggregate;
using Examples.Charge.Domain.Aggregates.ExampleAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public async Task<IEnumerable<PersonPhone>> FindAllAsync() => await Task.Run((Func<DbSet<PersonPhone>>)(() => _context.PersonPhone));


        public virtual async Task<PersonPhone> CreateAsync(PersonPhone obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();

            return obj;
        }

        public virtual async Task<PersonPhone> UpdateAsync(PersonPhone obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return obj;
        }

        public virtual async Task RemoveAsync(long id)
        {
            var obj = await GetAsync(id);

            if (obj != null)
            {
                _context.Remove(obj);
                await _context.SaveChangesAsync();
            }
        }

        public virtual async Task<PersonPhone> GetAsync(long id)
        {
            var obj = await _context.Set<PersonPhone>()
                                    .AsNoTracking()
                                    .Where(x => x.Id == id)
                                    .ToListAsync();

            return obj.FirstOrDefault();
        }

        public virtual async Task<List<PersonPhone>> GetAllAsync()
        {
            return await _context.Set<PersonPhone>()
                                 .AsNoTracking()
                                 .ToListAsync();
        }

        public virtual async Task<PersonPhone> GetAsync(
            Expression<Func<PersonPhone, bool>> expression,
            bool asNoTracking = true)
                => asNoTracking
                ? await BuildQuery(expression)
                        .AsNoTracking()
                        .FirstOrDefaultAsync()

                : await BuildQuery(expression)
                        .AsNoTracking()
                        .FirstOrDefaultAsync();

        public virtual async Task<IList<PersonPhone>> SearchAsync(
            Expression<Func<PersonPhone, bool>> expression,
            bool asNoTracking = true)
                => asNoTracking
                ? await BuildQuery(expression)
                        .AsNoTracking()
                        .ToListAsync()

                : await BuildQuery(expression)
                        .AsNoTracking()
                        .ToListAsync();

        private IQueryable<PersonPhone> BuildQuery(Expression<Func<PersonPhone, bool>> expression)
            => _context.Set<PersonPhone>().Where(expression);

        Task IPersonPhoneRepository.CreateAsync(PersonPhone obj)
        {
            throw new NotImplementedException();
        }

        Task IPersonPhoneRepository.UpdateAsync(PersonPhone obj)
        {
            throw new NotImplementedException();
        }
    }
}
