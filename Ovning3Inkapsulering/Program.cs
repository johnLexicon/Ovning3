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
                var pers1 = pH.CreatePerson(27, "Kalle", "Andersson", 180, 75);
                var pers2 = pH.CreatePerson(30, "Nisse", "Karlsson", 170, 70);

                // Try setting age and getting age with Personhandler
                pH.SetAge(pers1, 40);
                Console.WriteLine(pH.GetAge(pers1));

                // Try getting and setting firstname 
                pH.SetFName(pers1, "Gustav");
                Console.WriteLine(pH.GetFName(pers1));

            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }
    }
}
