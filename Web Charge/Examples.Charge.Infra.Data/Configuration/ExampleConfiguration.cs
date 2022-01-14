using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Examples.Charge.Domain.Aggregates.ExampleAggregate;

namespace Examples.Charge.Infra.Data.Configuration
{
    public class ExampleConfiguration : IEntityTypeConfiguration<PersonPhone>
    {
        public void Configure(EntityTypeBuilder<PersonPhone> builder)
        {
            builder.Ignore(b => b.DomainEvents);

            builder.ToTable("Example", "dbo").HasKey(t => t.Id);

            builder.Property(t => t.Id).IsRequired(true);
            builder.Property(t => t.Nome).IsRequired(true);

            builder.HasData(new PersonPhone { Id = 1, Nome = "Example 1" });
            builder.HasData(new PersonPhone { Id = 2, Nome = "Example 2" });
            builder.HasData(new PersonPhone { Id = 3, Nome = "Example 3" });
        }
    }
}
