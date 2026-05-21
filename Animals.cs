namespace knightmoves;

// should rename the Talk method on the Dog class to Say
// should rename the Sing method on the Bird class to Say
// should replace the if statements with a single call to the Say method on each of the animals

public class Trainer
{
    public string Listen(Animal[] animals)
    {
        string sounds = "";

        foreach (Animal animal in animals)
        {
            sounds += animal.Say() + ", ";
        }

        return sounds.TrimEnd(',', ' ');
    }
}

public abstract class Animal
{
    public abstract string Say();
}

public class Cat : Animal
{
    public override string Say()
    {
        return "meow";
    }
}

public class Dog : Animal
{
    public override string Say()
    {
        return "woof";
    }
}

public class Bird : Animal
{
    public override string Say()
    {
        return "chirp";
    }
}