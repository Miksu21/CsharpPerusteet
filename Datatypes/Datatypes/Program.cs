using System;

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // koodi tulee tänne
            // Syntax-syntaksi
            // syntax error
            // Tämä on kommentti
            // Kommentit eivät suorita mitään

            // Datatypes- datatyypit
            // Numeroita
            // 35- kokonaisluku - integer
            // 13.5- liukuluku - floating point
            // Merkkejä - char / merkkijono - string
            // 't' / "word"
            // Bool
            // true/falce 1/0
            // Literals
            // data on tallessa muuttujissa
            // <data_type> <variable name>
            //
            // int
            int apu = 5;
            int integerValue = 10; // puolipiste rivin loppuun
            integerValue = 15;

            // double - liukuluku
            double doubleValue;
            doubleValue = 3.14;
            // char
            char characterValue = 'r';
            // string
             string stringValue = "Word";
            // bool
            bool boolValue = false;

            // kommunikointi sovelluksen kanssa
            // käyttäjänä

            // luokaa muuttuja nimeltä message
            // ja antakaa sille arvoksi "Hello"
            string sMessage = "Hello";
            Console.WriteLine(sMessage);
            string input;
            input = Console.ReadLine();
            // "vastasit x", jossa x on käyttäjän syöte (input)
            Console.WriteLine("Vastasit: " +input);
            Console.WriteLine($"Interpolating {input}");
            Console.WriteLine("Vastasit: {0}", input);

            #region 3 C# Perus: Ikä-tehtävä
            // koodi
            Console.Write("Ookkonä minkä ikäne? ");
            string userInput = Console.ReadLine();
            int Ika = int.Parse(userInput);
            Console.WriteLine($"Olet {Ika} vuotta!");
            // ilmoita käyttäjän ikä kuukausina
            // tehdään yhdessä
            // +, -, *, /, %
            //int sum = 5 + 4;
            //sum = 7 - age;
            int sum = Ika * 12;
            Console.Write($"Olet {sum} kuukautta vanha!");


            // sum = 9
            // 
            #endregion

            #region 4 C# Perus: Palkan lasku
            // koodi pyydä käyttäjältä 4 eri arvoa ja suorita lasku
            double doubleValue 
            #endregion















        }
    }
}
