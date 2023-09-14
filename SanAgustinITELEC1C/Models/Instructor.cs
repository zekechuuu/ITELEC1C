﻿namespace SanAgustinITELEC1C.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }
    public class Instructor
    {
        public int InstructorID { get; set; }
        public string InstructorFirstName { get; set; }
        public string InstructorLastName { get; set; }
        public string IsTenured { get; set; }
        public Rank Rank { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
