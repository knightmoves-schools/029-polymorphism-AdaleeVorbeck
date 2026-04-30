namespace knightmoves;

//should rename the Talk method on the Dog class to Say
//should rename the Sing method on the Bird class to Say
//should replace the if statements with a single call to the Say method on each of the animals

public class Trainer{
    public string Listen(Animal[] animals) {
        string sounds = "";

        foreach(Animal animal in animals){
            if(typeof(Cat).IsInstanceOfType(animal))
            {
                sounds += ((Cat) animal).Say() + ", ";
            } 
            else if (typeof(Dog).IsInstanceOfType(animal))
            {   
                sounds += ((Dog) animal).Talk() + ", ";
            } 
            else if (typeof(Bird).IsInstanceOfType(animal))
            {
                sounds += ((Bird) animal).Sing() + ", ";
            }
        }

        return sounds;
    }
}

public abstract class Animal {
    
}

public class Cat : Animal{
    public string Say() {
        return "meow";
    }
}

public class Dog : Animal{
    public string Talk() {
        return "woof";
    }
}

public class Bird  : Animal{
    public string Sing() {
        return "chirp";
    }
}

