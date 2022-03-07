using System;

namespace SchoolLibrary
{
    public class Student : Person
    {   
        public enum GradeLevels
        {
            FRESHER, JUNIOR, SENIOR, SUPERSENIOR
        }
        public GradeLevels GradeLevel { get; set; }

        public override float ComputeGradeAverage()
        {
            return 0.0f;
        }
    }
}