using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createATownWithClass
{
    class Bank
    {
        //Name as a string
        public string Name { get; set; }
        //BuildingType as string, that is set in the constructor
        public string BuildingType { get; set; }
        public Bank (string btype)
        {
            BuildingType = btype;
        }
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
        //BathRooms as integer
        public int BathRooms { get; set; }
        //Volume as a Read Only, calculated field
        public int Volume { get; set; }
        //FullAddress as a Read only, string value that is made of the Address1, Address2, city, state, zip Properties
        public string FullAddress { get { return Address1 + Address2 + City + State + Zip; } }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        //Current Occupants as read only integer
        public int CurrentOccupants { get { return _CurrentOccupants; } }
        //IncreateOccupants as a public method that increments the CurrentOccupants by 1
        private int _CurrentOccupants;
        public void increaseCurrentOccupants()
        {
            _CurrentOccupants++;
        }
        //DecreaseOccupants as a public method that decrements the CurrentOccupants by 1
        public void decreaseCurrentOccupants()
        {
            _CurrentOccupants--;
        }
        //AmountOfMoney as private Double
        public double AmountOfMoney { get { return _AmountOfMoney; } }
        //DepositMoney as a public method, that modifies the AmountOfMoney
        private double _AmountOfMoney;
        public void IncreaseAmountOfMoney(double amount)
        {
            _AmountOfMoney+= amount;
        }
        //WithdrawMoney as a public method, that modifies the AmountOfMoney
        public void DecreaseAmountOfMoney(double amount)
        {
            _AmountOfMoney-= amount;
        }
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
