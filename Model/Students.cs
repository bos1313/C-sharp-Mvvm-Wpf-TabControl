using System;

namespace TabStudents.Model
{

    public class Students
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Dob { get; set; } = null!;
        

        public override string ToString()
        {
            return String.Format("{0}, {1}", FirstName, LastName);
        }

     
    }
    
}
