public class Dog : Pet, ITalkable
{
    public bool IsFriendly { get; set; }

    public Dog(bool isFriendly, string name) : base(name)
    {
        IsFriendly = isFriendly;
    }

    public override string Talk()
    {
        return "Woof";
    }

    public override string ToString()
    {
        return $"Dog: Name={Name}, Friendly={IsFriendly}";
    }
}