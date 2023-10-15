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
    public class AuthorsConfiguration : IEntityTypeConfiguration<Author>
    {


        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(Author => Author.FirstName)
                  .IsRequired()
                  .HasMaxLength(50);
            
            
            builder.Property(Author => Author.LastName)
                .HasDefaultValue("there isn't 'Lastname'")
                .HasMaxLength(50);
        }
         
    }
}
