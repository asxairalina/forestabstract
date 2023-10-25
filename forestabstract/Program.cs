using System.Collections.Generic;
using System.Xml.Linq;

Forest Forest = new Forest();
Animal Animal = new Hedgehog();
Hedgehog Hedgehog = new Hedgehog();
Hedgehog.Name = "Masha";
Hedgehog.Age = 14;
Animal.Info();
Hedgehog.Info();
Console.WriteLine(Animal);
Console.WriteLine(Hedgehog);
Animal.Sound();
Hedgehog.Sound();
Animal.Soft();
Hedgehog.Soft();

List<Animal> lst = new List<Animal>();
lst.Add(new Cow());
lst.Add(new Monkey());
lst.Add(new Voolf());
lst.Add(new Dog());
lst.Add(new Bear());
foreach (var i in lst)
{
    i.Move();
}

class Forest
{
    List<Hedgehog> Hedgehog = new List<Hedgehog>()
    {
        new Hedgehog(), new Hedgehog(),
    };

}

abstract class Animal
{

    public string Name { get; set; }

    public int Age { get; set; }

    public abstract void Sound();
    public abstract void Info();
    public abstract void Soft();

}


//public virtual void Sound()
//    {
//        Console.WriteLine($"...");
//    }

//    public virtual void Info()
//    {
//        Console.WriteLine($"Animal - {Name} {Age} old");
//    }

//    public virtual void Soft()
//    {
//        Console.WriteLine($"soft");
//    }
//}

class Hedgehog : Animal
{
    public override void Info()
    {
        Console.WriteLine($"Hedgehog - {Name}");
    }

    public override void Sound()
    {
        Console.WriteLine($"frr-frr");
    }

    public override void Soft()
    {
        Console.WriteLine($"dont soft");
    }
}

class Cow : Animal 
{
    public override void Info()
    { 
        Console.WriteLine()
    }
}
class Monkey : Animal 
{
    public override void Info() { }
}
    
class Voolf : Animal 
{
    public override void Info() { }
}
class Dog : Animal 
{ 
    public override void Info() { }
}
class Hog : Animal 
{
    public override void Info() { }
}

