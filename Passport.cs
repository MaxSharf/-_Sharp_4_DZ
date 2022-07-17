using System;
using System.Collections.Generic;
using System.Text;

namespace С_Sharp_4_DZ
{
   public class Passport
    {

        public string name { set; get; }
        public string secongName { set; get; }
        public string country { set; get; }
        public int codPasvort { set; get; }
        public int age { get; set; }


        public Passport()
        {
            name = null;
            secongName = null;
            country = null;
            codPasvort = 0;
            age = 0;
        }

        public Passport(string name , string secongName , string country , int codPasvort , int age)
        {
            this.name = name;
            this.secongName = secongName;
            this.country = country;
            this.codPasvort = codPasvort;
            this.age = age;
        }

        public void fiilPasport()
        {
            Console.WriteLine($" Інформація про клас Human : \n Ім'я - {name} ,\n Прізвише - {secongName} ,\n Повних років - {age} ,\n Країна - {country}  , \n Код паспорта - {codPasvort}.");

        }
        public void EnterPasport()
        {
            Console.WriteLine($"Введіть Ім'я ");
            name = Console.ReadLine();
            Console.WriteLine($"Введіть Прізвище ");
            secongName = Console.ReadLine();
            Console.WriteLine($"Введіть ваш вік ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введіть вашу країну ");
            country = Console.ReadLine();
            Console.WriteLine($"Введіть номер паспорта");
            codPasvort = Convert.ToInt32(Console.ReadLine());
        }



    }

    public class ForeignPassport : Passport
    {
        public string viza { get; set; }
        public int numberForeignPass { set; get; }

        public ForeignPassport()
        {
            viza = null;
            numberForeignPass = 0;
        }

        public ForeignPassport(string viza , int numberForignPass) :base ( )
        {
            this.viza = viza;
            this.numberForeignPass = numberForeignPass;
        }


        public void OutInfoForeignPasport()
        {
            Console.WriteLine($" Інформація про клас Human : \n Ім'я - {name} ,\n Прізвише - {secongName} ,\n Повних років - {age} ,\n Країна - {country}  , \n Код паспорта - {codPasvort}.");

        }
        public void FillForeignPasport()
        {
            Console.WriteLine($"Введіть Ім'я ");
            name = Console.ReadLine();
            Console.WriteLine($"Введіть Прізвище ");
            secongName = Console.ReadLine();
            Console.WriteLine($"Введіть ваш вік ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введіть вашу країну ");
            country = Console.ReadLine();
            Console.WriteLine($"Введіть номер паспорта");
            codPasvort = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Наявнісь візи");
            viza = Console.ReadLine();
            Console.WriteLine($"Введіть номер закордоного папорта");
            numberForeignPass = Convert.ToInt32(Console.ReadLine());

        }



    }


}
