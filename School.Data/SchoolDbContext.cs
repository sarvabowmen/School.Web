using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Models;

namespace School.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext() : base("name=SchoolDBConnectionString")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamType> ExamTypes { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<UserSections> UserSections { get; set; }
        public DbSet<GradeSection> GradeSections { get; set; }

        public virtual void Commit() { 
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new UserSectionConfiguration());
            modelBuilder.Configurations.Add(new ExamConfiguration());
            modelBuilder.Configurations.Add(new ExamTypeConfiguration());
            modelBuilder.Configurations.Add(new ExamResultConfiguration());
            modelBuilder.Configurations.Add(new GradeConfiguration());
            modelBuilder.Configurations.Add(new CourseConfiguration());
            modelBuilder.Configurations.Add(new GradeSectionConfiguration());
        }
    }
}
