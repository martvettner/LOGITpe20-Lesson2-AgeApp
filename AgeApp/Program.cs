using System;

namespace AgeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mis su nimi on");
            string name = Console.ReadLine();
            Console.WriteLine("tere, "+ name);
            Console.WriteLine("mis aastal sa sündisid?");
            string UserInput;
            UserInput = Console.ReadLine();
            int SynniAasta;
            SynniAasta = Int32.Parse(UserInput);
                int age = 2020 - SynniAasta;
                Console.WriteLine("sa oled " + age + " vana");




        }
    }
}
