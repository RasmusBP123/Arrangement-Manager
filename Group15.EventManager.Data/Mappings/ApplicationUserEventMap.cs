using Group15.EventManager.Domain.Models.Joint;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Group15.EventManager.Data.Mappings
{
    public class ApplicationUserEventMap : IEntityTypeConfiguration<ApplicationUserEvent>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserEvent> builder)
        {
            builder.ToTable("UserEvents");
            builder.HasKey(aue => new { aue.ApplicationUserId, aue.EventId });
            builder.HasOne(aue => aue.Event).WithMany(e => e.UserEvents).HasForeignKey(aue => aue.EventId);
            builder.HasOne(aue => aue.User).WithMany(u => u.UserEvents).HasForeignKey(aue => aue.ApplicationUserId);
        }
    }
}


//    modelBuilder.Entity<BookCategory>().HasKey(bc => new { bc.BookId, bc.CategoryId }); 

//    modelBuilder.Entity<BookCategory>().HasOne(bc => bc.Book).WithMany(b => b.BookCategories).HasForeignKey(bc => bc.BookId);
//    modelBuilder.Entity<BookCategory>().HasOne(bc => bc.Category).WithMany(c => c.BookCategories).HasForeignKey(bc => bc.CategoryId);