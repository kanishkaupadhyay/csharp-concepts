using System;

namespace SchoolLibrary
{
    public class Teacher : Person
    {   
        public string Subject { get; set; }

        public override float ComputeGradeAverage()
        {
            return 1.0f;
        }
    }
}