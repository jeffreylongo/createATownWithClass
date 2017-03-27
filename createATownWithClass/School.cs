using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createATownWithClass
{
    class School
    {
        //Name as a string
        public string Name { get; set; }
        //BuildingType as string, that is set in the constructor
        public string BuildingType { get; set; }
        //NumberOfRoom as an int
        public int NumberOfRoom { get; set; }
        //ConstructionMaterial as a string
        public int ConstructionMaterial { get; set; }
        //Height as double
        public double Height { get; set; }
        //Width as double
        public double Width { get; set; }
        //Length as Double
        public double Length { get; set; }
        //Square Footage as a Read Only, calculated field
        public int SquareFootage { get; }
        //Floors as integer
        public int Floors { get; set; }
        //Classrooms as integer
        public int Classrooms { get; set; }
        //BathRooms as integer
        public int BathRooms { get; set; }
        //Volume as a Read Only, calculated field
        public int Volume { get; set; }
        //FullAddress as a Read only, string value that is made of the Address1, Address2, city, state, zip Properties
        public string FullAddress { get; }
        //Current Occupants as read only integer
        public int CurrentOccupants { get; }
        //IncreateOccupants as a public method that increments the CurrentOccupants by 1
        private int _CurrentOccupants;
        public void IncreaseCurrentOccupants()
        {
            _CurrentOccupants++;
        }
        //DecreaseOccupants as a public method that decrements the CurrentOccupants by 1
        public void DecreaseCurrentOccupants()
        {
            _CurrentOccupants--;
        }
        //NumberOfStudents as int
        public int NumberOfStudents { get; set; }
        //InSession as Boolean
        public bool Insession { get; set; }
        //NumberOfTeachers as a Integer
        public int NumberOfTeachers { get; set; }
        //TeacherStudentRatio as a method that returns a string in the format ${teacher}:{student}
        //this is the display name method that should display the property name
        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
        //this is the to string method that should return $"{BuildingType} : {Name}"
        public override string ToString()
        {
            return $"{BuildingType} : {Name}";
        }
    }
}
