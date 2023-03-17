using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsCarsApp
{
    public class Car
    {
        private int id;
        private string name;
        private string brand;
        private int horsePower;
        private int mileage;
        private int numberOfWheels;
        private string color;
        private int serialNumber;
        private int numberOfLeters;
        private int age;
        private int price;
        public Car()
        {

        }
       public Car( int id,string name,string brand, int horsePower, int mileage, int numberOfWheels,string color , int serialNumber, int numberOfLeters,int age)
        {
            Id = id;
            Name = name;
            Brand = brand;
            HorsePower = horsePower;
            Mileage = mileage;
            NumberOfWheels = numberOfWheels;
            Color = color;
            SerialNumber = serialNumber;
            NumberOfLeters = numberOfLeters;
            Age = age;
            Price = 0;
        }
        public Car(int id, string name)
        {
            Id = id;
            Name = name;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int HorsePower { get; set; }
        public int Mileage { get; set; }
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public int SerialNumber { get; set; }
        public int NumberOfLeters { get; set; }
        public int Age { get; set; }
        public int Price { get; set; }
    }
}
