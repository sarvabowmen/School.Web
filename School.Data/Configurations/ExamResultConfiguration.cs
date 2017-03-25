using System;
using School.Models;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace School.Data
{
    public class ExamResultConfiguration: EntityTypeConfiguration<ExamResult>
    {
        public ExamResultConfiguration()
        {
            ToTable("ExamResult");
            HasKey(s => new { s.CourseID, s.ExamID, s.StudentID });
            Property(e => e.Marks).IsRequired();
        }
    }
}
