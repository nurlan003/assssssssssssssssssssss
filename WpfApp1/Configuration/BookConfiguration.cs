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
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.ID);


            builder.Property(Book => Book.Name)
                  .IsRequired()
                  .HasMaxLength(50);


            builder.Property(Book => Book.Pages)
                .IsRequired();



            builder.Property(Book => Book.YearPress)
           .IsRequired()
           .HasMaxLength(20);

            builder.Property(Book => Book.Comment)
           .HasDefaultValue("Not Comment")
           .HasMaxLength(200);

            builder.Property(Book => Book.Quantity)
           .HasDefaultValue("0")
           .HasMaxLength(1000);

            builder.HasOne<Theme>()
                .WithMany()
                .HasForeignKey(x => x.ThemesId);

            builder.HasOne<Category>()
            .WithMany()
           .HasForeignKey(x => x.CategoryId);

            builder.HasOne<Author>()
            .WithMany()
            .HasForeignKey(x => x.AuthorId);

            builder.HasOne<Press>()
            .WithMany()
           .HasForeignKey(x => x.PressId);
        }
    }
}
