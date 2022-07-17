using System;
using System.Collections.Generic;
using System.Text;

namespace С_Sharp_4_DZ
{
    public class Human
    {
        public string name { get; set; }
        public string secondName { get; set; }
        public int age { get; set; }
        public string profesia { get; set; }



        public Human()
        {
            name = null;
            secondName = null;
            age = 0;
            profesia = null;

        }
        public Human(string name, string secondName , int age , string profesia)
            {
            this.name = name;
            this.secondName = secondName;
            this.age = age;
            this.profesia = profesia;
        }
        public virtual void Out()
        {
            Console.WriteLine($" Інформація про клас Human : \n Ім'я - {name} ,\n Прізвише - {secondName} ,\n Повних років - {age} ,\n Професія - {profesia} .");
        }
        public void FillInfo()
        {
            Console.WriteLine($"Введіть Ім'я ");
            name = Console.ReadLine();
            Console.WriteLine($"Введіть Прізвище ");
            secondName = Console.ReadLine();
            Console.WriteLine($"Введіть ваш вік ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введіть вашу професію ");
            profesia = Console.ReadLine();


        }
    }

    public class Builder : Human
    {
        public Builder(string name, string secondName, int age, string profesia) : base (name , secondName , age , profesia)
        {
            name = " Max";
            secondName = " sharf";
            age = 18;
            profesia = "Builder";

        }



    }






}
