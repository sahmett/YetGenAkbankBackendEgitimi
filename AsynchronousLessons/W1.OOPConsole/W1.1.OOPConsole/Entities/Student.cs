﻿namespace W1._1.OOPConsole.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Student(int ıd, string firstName, string lastName)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
        }
        public Student() { }
    }
}