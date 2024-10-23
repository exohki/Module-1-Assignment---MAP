using System;
using System.Collections;

public class AnimalCreator
{
    private ArrayList zoo;

    public AnimalCreator(ArrayList zoo)
    {
        this.zoo = zoo;
    }

    public void CreateAnimal()
    {
        Console.WriteLine("What type of entity would you like to create? (Cat/Dog/Teacher)");
        string choice = Console.ReadLine().ToLower();

        switch (choice)
        {
            case "cat":
                CreateCat();
                break;
            case "dog":
                CreateDog();
                break;
            case "teacher":
                CreateTeacher();
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    private void CreateCat()
    {
        Console.Write("Enter the number of mice the cat has killed: ");
        int mousesKilled = int.Parse(Console.ReadLine());

        Console.Write("Enter the name of the cat: ");
        string name = Console.ReadLine();

        Cat cat = new Cat(mousesKilled, name);
        zoo.Add(cat);

        Console.WriteLine("Cat created successfully.");
    }

    private void CreateDog()
    {
        Console.Write("Is the dog friendly? (true/false): ");
        bool friendly = bool.Parse(Console.ReadLine());

        Console.Write("Enter the name of the dog: ");
        string name = Console.ReadLine();

        Dog dog = new Dog(friendly, name);
        zoo.Add(dog);

        Console.WriteLine("Dog created successfully.");
    }

    private void CreateTeacher()
    {
        Console.Write("Enter the age of the teacher: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter the name of the teacher: ");
        string name = Console.ReadLine();

        Teacher teacher = new Teacher(age, name);
        zoo.Add(teacher);

        Console.WriteLine("Teacher created successfully.");
    }
}