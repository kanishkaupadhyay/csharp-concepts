using System;

namespace SchoolLibrary
{
    class School
    {
        // Auto-Implemented  Properties
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        // backing variable for the property
        private string _twitterAddress;
        // Creating Properties
        public string TwitterAddress 
        {
            get { return _twitterAddress; }
            set 
            {   
                // value is this hidden variable exists in c# and works within the context of get and set when you are creating your properties
                if(value.StartsWith("@"))
                {
                    _twitterAddress = value;
                } else
                {
                    throw new Exception("Twitter address must begin with @");
                }
            }
        }

        // constructor
        public School()
        {
            Name = "High School";
            PhoneNumber = "140-213-455";
        }
        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }

        // methods
        public int AverageScores(int math, int science){
            return (math+science)/2;
        }

        // overloaded methods
        public float AverageScores(float math, float science){
            return (math+science)/2;
        }
        // function bodied expression and static method
        public static int TotalScore(int math, int science) => math + science;

        // overriding ToString()
        public override string ToString()
        {
            string schoolInfo = string.Format("School:{0}\nPhone Number:{1}\nCity:{3}", Name, PhoneNumber, City);
            return schoolInfo;
        }
    }
}