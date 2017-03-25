using System;
using School.Models;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace School.Data
{
    public class GradeSectionConfiguration : EntityTypeConfiguration<GradeSection>
    {
        public GradeSectionConfiguration()
        {
            ToTable("GradeSection");
            HasKey(u => u.GradeSectionID);

            Property(u => u.GradeSectionID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //relationship  
            HasRequired(t => t.Grade).WithMany(c => c.GradeSections).HasForeignKey
                    (t => t.GradeID).WillCascadeOnDelete(false);


        }
    }
}
