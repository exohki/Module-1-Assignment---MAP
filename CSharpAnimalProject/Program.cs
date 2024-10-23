using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList zoo = new ArrayList();

        AnimalCreator animalCreator = new AnimalCreator(zoo);

        bool continueAdding = true;
        while (continueAdding)
        {
            animalCreator.CreateAnimal();

            Console.Write("Do you want to add another entry? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            if (response != "yes")
            {
                continueAdding = false;
            }
        }

        Console.WriteLine("\n--- Zoo Entries ---");
        foreach (ITalkable entry in zoo)
        {
            Console.WriteLine(entry);
            Console.WriteLine("Phrase: " + entry.Talk());
        }
    }
}