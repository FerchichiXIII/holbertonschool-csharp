using System;
/// <summary>
/// interface IInteractive
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// interact
    /// </summary>
    void Interact();
}
/// <summary>
/// interface IBreakable
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// int 
    /// </summary>
    int durability { get; set; }
    /// <summary>
    /// method
    /// </summary>
    void Break();
}
/// <summary>
/// interface ICollectable
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// property
    /// </summary>
    bool isCollected { get; set; }
    /// <summary>
    /// method
    /// </summary>  
    void Collect();
}
/// <summary>
/// obstract class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// string name
    /// </summary>
    public string name { get; set; }
    /// <summary>
    /// Overide ToString Method
    /// </summary>
    public override string ToString()
    {
        return ($"{name} is a {this.GetType()}");
    }
}
/// <summery>
/// Class Door
/// </summery>
public class Door : Base, IInteractive {

    /// <summary>
    /// COnstructor of Door
    /// </summary>
    /// <param name="name"></param>
    public Door(string name="Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Interact implementation
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}
/// <summary>
/// Class Decoration
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary> Durabillity property </summary>
    /// <value> Integer </value>
    public int durability { get; set; }
    /// <summary> Boolean Value </summary>
    /// <value> Integer </value>
    public bool isQuestItem { get; set; }
    /// <summary> Decoration </summary>
    /// <param name="name"></param>
    /// <param name="durability"></param>
    /// <param name="isQuestItem"></param>

    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Implementation of Interact
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }
    /// <summary>
    /// Break imp
    /// </summary>
    public void Break()
    {
        durability --;
        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}
/// <summary>
/// Class representing a key object.
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// Gets or sets a value indicating whether the key is collected.
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// Constructor for the Key class.
    /// </summary>
    /// <param name="name">The name of the key.</param>
    /// <param name="isCollected">Whether the key is collected.</param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Implementation of the Collect method.
    /// </summary>
    public void Collect()
    {
        if (isCollected)
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
        else
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
    }
}
