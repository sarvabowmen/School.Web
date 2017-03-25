using System;
using School.Models;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace School.Data
{
    public class ExamConfiguration : EntityTypeConfiguration<Exam>
    {
        public ExamConfiguration()
        {
            ToTable("Exam");
            HasKey(u => u.ExamID);
            Property(e => e.ExamName).IsRequired();

            Property(u => u.ExamID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //relationship  
            HasRequired(t => t.ExamType).WithMany(c => c.Exams).HasForeignKey
                    (t => t.ExamTypeId).WillCascadeOnDelete(false);
        }
    }
}
