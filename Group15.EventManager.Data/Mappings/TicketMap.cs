using Group15.EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Group15.EventManager.Data.Mappings
{
    public class TicketMap : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Tickets");
            builder.HasKey(t => t.Id);

            builder.HasData(new
            {
                Id = new Guid("a1f30749-d72d-422f-860c-534d49297bd8"),
                UserId = new Guid("a14280f8-d2b9-4598-8c89-c699cd1ab278"),
                CreatedDate = new DateTime(2020, 01, 09),
            });
        }
    }
}
