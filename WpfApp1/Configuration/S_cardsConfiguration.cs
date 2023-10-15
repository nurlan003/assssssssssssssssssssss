using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Configuration
{
    public class S_cardsConfiguration : IEntityTypeConfiguration<S_Card>
    {
        public void Configure(EntityTypeBuilder<S_Card> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne<Student>()
       .WithMany()
       .HasForeignKey(x => x.StudentId);

            builder.HasOne<Lib>()
       .WithMany()
       .HasForeignKey(x => x.LibId);


            builder.HasOne<Book>()
              .WithMany()
        .HasForeignKey(x => x.BookntId);

            builder.Property(S_Card => S_Card.CreatedDate)
         .IsRequired();
            builder.Property(S_Card => S_Card.ModifiedDate)
         .IsRequired();

        }
    }
}
