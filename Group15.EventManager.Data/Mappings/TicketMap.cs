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
                Id = new Guid("6d60a26b-17de-4501-a1d1-4b21f564bc63"),
                UserId = new Guid("363f53b7-6ee1-4a60-bee9-1af8712551a5"),
                EventId = new Guid("24ce1d49-dff7-4444-b931-fa573c6b83ce"),
                CreatedDate = new DateTime(2019, 12, 04, 11, 20, 00)
            });
        }
    }
}
