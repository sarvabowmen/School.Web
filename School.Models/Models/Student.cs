using System;

namespace School.Models
{
    public class Student
    {
        public int Id { get; set; }

        public int StudentRollNo { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Status Status { get; set; }
    }

    public enum Status {
        Active = 1,
        InActive = 0
    }
}
