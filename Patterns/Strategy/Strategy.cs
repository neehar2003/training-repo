// Strategy pattern
// Problem: the same action can be done in different ways (here, a duck making a sound)
// Instead of if else, each way gets its own class (Quack,Cry) and we pick one when we need it.

interface ISound
{
    void Make();
}

class Quack : ISound
{
    public void Make()
    {
        Console.WriteLine("Quack");
    }
}

class Cry : ISound
{
    public void Make()
    {
        Console.WriteLine("Cry");
    }
}

class Duck
{
    public ISound Sound;

    public void Speak()
    {
        Sound.Make();
    }
}

// Usage:
// var duck = new Duck();   //creates a duck

// duck.Sound = new Quack();
// duck.Speak();   // Quack

// duck.Sound = new Cry();
// duck.Speak();   // Cry
