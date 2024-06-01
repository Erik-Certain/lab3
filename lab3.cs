using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Создание героя с арсеналом вооружения
        var hero = new Hero(new List<Equipment>
        {
            new Armor("Chainmail"), // Кольчуга
            new Weapon("Sword"),    // Меч
            new Armor("Helmet"),    // Шлем
            new Weapon("Bow")       // Лук
        });

        // Вывод вооружения героя в консоль
        hero.DisplayArsenal();
    }
}

// Класс героя
public class Hero
{
    // Коллекция вооружения героя
    public List<Equipment> Arsenal { get; private set; }

    // Конструктор
    public Hero(List<Equipment> arsenal)
    {
        Arsenal = arsenal;
    }

    // Метод для отображения арсенала
    public void DisplayArsenal()
    {
        Console.WriteLine("Arsenal of the Hero:");
        foreach (var item in Arsenal)
        {
            Console.WriteLine(item.Name);
        }
    }
}

// Абстрактный класс снаряжения
public abstract class Equipment
{
    // Название снаряжения
    public string Name { get; private set; }

    // Конструктор
    protected Equipment(string name)
    {
        Name = name;
    }
}

// Класс доспехов
public class Armor : Equipment
{
    public Armor(string name) : base(name)
    {
    }
}

// Класс оружия
public class Weapon : Equipment
{
    public Weapon(string name) : base(name)
    {
    }
}