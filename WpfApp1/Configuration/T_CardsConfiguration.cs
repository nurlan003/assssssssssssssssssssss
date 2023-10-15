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
    public class T_CardsConfiguration : IEntityTypeConfiguration<T_Card>
    {
        public void Configure(EntityTypeBuilder<T_Card> builder)
        {
            builder.HasOne<Teacher>()
            .WithMany()
            .HasForeignKey(x => x.TeacherId);

            builder.HasOne<Lib>()
            .WithMany()
            .HasForeignKey(x => x.LibId);


            builder.HasOne<Book>()
       .WithMany()
       .HasForeignKey(x => x.BookId);
        }
    }
}
