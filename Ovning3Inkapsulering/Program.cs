using System;

namespace Ovning3Inkapsulering
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Check access to properties 
                //Person person = new Person();
                //person.FName = "Kalle";


                // Create persons
                
                PersonHandler pH = new PersonHandler();
                var pers1 = pH.CreatePerson(27, "Kalle", "Andersson", 1.85, 75);
                var pers2 = pH.CreatePerson(30, "Nisse", "Karlsson", 1.75, 70);

                // Try setting age and getting age with Personhandler
                pH.SetAge(pers1, 40);
                Console.WriteLine($"{pers1.FName} {pers1.LName} is {pH.GetAge(pers1)} years old");

                // Try getting and setting firstname 
                Console.WriteLine($"Person 1 Firstname: {pers1.FName}");
                pH.SetFName(pers1, "Gustav");

                Console.WriteLine($"Person 1 changed name to {pH.GetFName(pers1)}");

                // Try getting and setting height and weight
                Console.WriteLine($"{pers2.FName} is {pers2.Height}");
                pH.SetHeight(pers2, 1.73);
                Console.WriteLine($"{pers2.FName} is {pers2.Height}");


            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }
    }
}
