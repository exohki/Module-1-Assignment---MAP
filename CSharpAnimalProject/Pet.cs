public abstract class Pet
{
    public string Name { get; set; }

    public Pet(string name)
    {
        Name = name;
    }

    public abstract string Talk();
}