using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsCarsApp
{
    public class Owner
    {
        private int id;
        private string firstName;
        private string lastName;
        private string phone;
        private string adress;
        private int age;
        private List<Car> listOfCars;
        Owner(int id, string firstName, string lastName, string phone, string adress, int age , List<Car> listOfCars)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.adress = adress;
            this.age = age;
            this.listOfCars = listOfCars;
        }
    }
}
