public class Cat : Pet, ITalkable
{
    public int MousesKilled { get; set; }

    public Cat(int mousesKilled, string name) : base(name)
    {
        MousesKilled = mousesKilled;
    }

    public override string Talk()
    {
        return "Meow";
    }

    public override string ToString()
    {
        return $"Cat: Name={Name}, MousesKilled={MousesKilled}";
    }
}