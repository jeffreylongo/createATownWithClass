using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createATownWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<House> houses = new List<House>();
            House houseOne = new House("brick");
            House houseTwo = new House("wood");
            House houseThree = new House("concrete");
            houses.Add(houseOne);
            houses.Add(houseTwo);
            houses.Add(houseThree);
            

            List<Bank> banks = new List<Bank>();
            Bank bankOne = new Bank("brick");
            Bank bankTwo = new Bank("teepee");
            Bank bankThree = new Bank("wood");

            List<School> schools = new List<School>();
            School schoolOne = new School("wood");
            School schoolTwo = new School("brick");
            School schoolThree = new School("concrete");
        }
    }
}
