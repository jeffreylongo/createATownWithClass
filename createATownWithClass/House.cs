using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createATownWithClass
{
    class House
    {
        //Name as a string
        public string Name { get; set; }
        //BuildingType as string, that is set in the constructor
        public string BuildingType { get; set; }
        //NumberOfRoom as an int
        public int NumberOfRoom { get; set; }
        //ConstructionMaterial as a string
        public string ConstructionMaterial { get; set; }
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
        //BedRooms as integer
        public int BedRooms { get; set; }
        //BathRooms as integer
        public int BathRooms { get; set; }
        //Volume as a Read Only, calculated field
        public int Volume { get; }
        //FullAddress as a Read only, string value that is made of the Address1, Address2, city, state, zip Properties
        public string FullAddress { get; set; }
        //Current Occupants as read only integer
        public int CurrentOccupants { get; }
        //IncreateOccupants as a public method that increments the CurrentOccupants by 1
        //DecreaseOccupants as a public method that decrements the CurrentOccupants by 1
    }
}
