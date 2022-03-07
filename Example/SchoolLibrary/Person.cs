using System;
using System.Text;

namespace SchoolLibrary
{
    // to make a class non instantiable use abstract keyword
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public abstract float ComputeGradeAverage();

        public virtual string SendMessage(string mesaage)
        {
            StringBuilder messageString = new StringBuilder();
            var timeStamp = string.Format("Sent on {0:D} at {0:D}", DateTime.Now);
            messageString.AppendLine(timeStamp);
            messageString.AppendLine("");
            messageString.AppendLine("Dear " + FirstName + ", ");
            messageString.AppendLine(mesaage);
            return messageString.ToString();
        }
    }
}