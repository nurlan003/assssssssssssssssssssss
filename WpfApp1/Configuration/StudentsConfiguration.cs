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
    public class StudentsConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(Student => Student.FirstName).IsRequired();
            builder.Property(Student => Student.LastName).IsRequired();

            builder.Property(Student => Student.Term).IsRequired();

            builder.HasOne<Group>()
       .WithMany()
       .HasForeignKey(x => x.GroupId);
        }
    }
}
