using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var hero = new Hero(new List<Equipment>
        {
            new Armor("Chainmail"),
            new Weapon("Sword"),
            new Armor("Helmet"),
            new Weapon("Bow")
        });
      
        hero.DisplayArsenal();
    }
}

public class Hero
{
    public List<Equipment> Arsenal { get; private set; }

    public Hero(List<Equipment> arsenal)
    {
        Arsenal = arsenal;
    }
  
    public void DisplayArsenal()
    {
        Console.WriteLine("Arsenal of the Hero:");
        foreach (var item in Arsenal)
        {
            Console.WriteLine(item.Name);
        }
    }
}

public abstract class Equipment
{
    public string Name { get; private set; }

    protected Equipment(string name)
    {
        Name = name;
    }
}

public class Armor : Equipment
{
    public Armor(string name) : base(name)
    {
    }
}

public class Weapon : Equipment
{
    public Weapon(string name) : base(name)
    {
    }
}