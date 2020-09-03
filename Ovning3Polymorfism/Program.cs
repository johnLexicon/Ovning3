using System;
using System.Collections.Generic;

namespace Ovning3Polymorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UserError> userErrors = new List<UserError>
            {
                new NumericInputError(),
                new TextInputError(),
                new NumericInputError(),
                new TooLongPasswordError(),
                new TooShortPasswordError(),
                new SpecialCharacterError()
            };

            foreach (var userError in userErrors)
            {
                Console.WriteLine(userError.UEMessage());
            }
            Console.ReadKey();
        }

        // Fråga 11: För att man slipper skriva dupplicerad kod då subklassen ärver från basklassen, samtidigt har man flexibiliteten att lägga till metoder i subklassen
                  // Också att man kan behandla subklasserna som instanser av basklassen, detta leder till att man kan lättare gruppera och behandla de som samma 
        
        // Fråga 12: Utöver att man slipper skriva dupplicerad kod, blir det även lättare att ändra vid ett senare tillfälle. Det blir också lättare att läsa koden.
                  // Om man använder Interface så kan man gömma detaljerna av subklasserna också
        
        // Fråga 13: Med ett Iterface definerar man bara funktioner utan att implementera, medans med en Abstract klass man kan implementera och overrida sen
                  // Man kan ärva från flera Interface, men ej Abstract klass. Metoder i Interfaces måste implementeras i subklasserna. Abstract klass kan ej instantieras
    }
}
