using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCarApp
{
    public class Cache
    {
        private static readonly Random getrandom = new Random();
        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }
        private static Cache instance = new Cache();
        private List<ModelsCarsApp.Car> listOfCars = new List<ModelsCarsApp.Car>();
        private Cache() { }
        public static Cache Instance
        {
            get { return instance; }
        }

        public void setTimer()
        {
            foreach(ModelsCarsApp.Car c in listOfCars)
            {
                c.Price = GetRandomNumber(0,100);

                Console.WriteLine(c.Price);
                Console.WriteLine(c.Brand);
            }
        }
        public void AddCar(ModelsCarsApp.Car c)
        {
            listOfCars.Add(c);
        }
        public void deleteFromList(Int64 id)
        {
            ModelsCarsApp.Car car =  listOfCars.First(s => s.Id == id);
            listOfCars.Remove(car);
        }

        public void modifyFromList(Int64 id,string name,string brand,int horsePower,int mileage,int numberOfWheels,string color,int serialNumber,int numberOfLeters ,int age)
        {
            int index = listOfCars.FindIndex(s => s.Id == id);
            listOfCars[index].Name = name;
            listOfCars[index].Brand = brand;
            listOfCars[index].HorsePower = horsePower;
            listOfCars[index].Mileage = mileage;
            listOfCars[index].NumberOfWheels = numberOfWheels;
            listOfCars[index].Color = color;
            listOfCars[index].SerialNumber = serialNumber;
            listOfCars[index].NumberOfLeters = numberOfLeters;
            listOfCars[index].Age = age;

        }
            public void printCars()
        {
            Console.WriteLine(listOfCars.Count);
        }

        public List<ModelsCarsApp.Car> getListOfCars()
        {
            return this.listOfCars;
        }
    }
}
