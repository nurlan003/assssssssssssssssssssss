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
    public class TeachersConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(Teacher => Teacher.ID);

            builder.HasOne<Department>()
                .WithMany()
               .HasForeignKey(x => x.DepartmentId);


            builder.Property(Teacher => Teacher.FirstName).IsRequired();
            builder.Property(Teacher => Teacher.LastName).IsRequired();


        }
    }
}
