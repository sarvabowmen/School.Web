using System;
using School.Models;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace School.Data
{
    public class GradeConfiguration : EntityTypeConfiguration<Grade>
    {
        public GradeConfiguration()
        {
            ToTable("Grade");
            HasKey(u => u.GradeID);

            Property(u => u.GradeID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           
        }
    }
}
