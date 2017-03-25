using System;
using School.Models;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace School.Data
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("Users");
            HasKey(u => u.Id);

            Property(u => u.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(u => u.DisplayID).IsRequired().HasMaxLength(25).HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("IX_FirstNameLastName", 1) { IsUnique = true }));
            Property(u => u.Id).IsRequired();
            Property(u => u.FirstName).IsRequired();
            Property(u => u.LastName).IsRequired();

        }
    }
}
