using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_to_canteen
{
    class Settings
    {

    }

    class Canteen
    {
        public string NameOfDish { get; set; }
        public int IdOfDish = 0;

        public Canteen(string nameOfDish)
        {
            NameOfDish = nameOfDish;
            IdOfDish++;
        }
    }

    class SchoolClass
    {
        public int CountOfPupils { get; set; }
        public int Budget { get; set; }

        public SchoolClass(int countOfPupils, int budget)
        {
            CountOfPupils = countOfPupils;
            Budget = budget;
        }
    }

    class Student
    {        
        public string Name { get; set; }
        public int Money { get; set; }
        public string Order { get; set; }

        public Student(string name, int money, string order)
        {
            Name = name;
            Money = money;
            Order = order;
        }
    }
}
