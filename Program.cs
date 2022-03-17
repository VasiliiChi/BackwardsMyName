using System;

namespace BackwardsMyName
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите свое имя:");
            var name = Console.ReadLine();

            Console.WriteLine("\nВаше имя по буквам:");
        foreach (var nm in name)
        {
                Console.Write("{0} ", nm);
        }
            Console.WriteLine("\n\nПервая буква Вашего имени: {0}", name[0]);
            Console.WriteLine("Последняя буква Вашего имени: {0}", name[name.Length-1]);

            Console.Write("\nВаше имя наоборот: ");
            for (int i = name.Length-1; i >= 0; i--)
            {
                Console.Write(name[i] + " ");
            }



            Console.ReadKey();
        }
    }
}
