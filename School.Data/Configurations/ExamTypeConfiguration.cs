using System;
using School.Models;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace School.Data
{
    public class ExamTypeConfiguration : EntityTypeConfiguration<ExamType>
    {
        public ExamTypeConfiguration()
        {
            ToTable("ExamType");
            HasKey(u => u.ExamTypeID);
            Property(e => e.ExamTypeName).IsRequired();


            Property(u => u.ExamTypeID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           
        }
    }
}
