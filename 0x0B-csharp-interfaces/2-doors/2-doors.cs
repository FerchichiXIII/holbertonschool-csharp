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
public class Door : Base, IInteractive
{
    /// <summery>
    /// String Name
    /// </summery>
    public string name { get; set; }

    public Door()
    {
        /// <summery>
        /// Door name
        /// </summery>
        name = "Door";
    }

    public Door(string name)
    {
        /// <summery>
        /// String Door
        /// </summery>
        this.name = name;
    }

    public void Interact()
    {
        /// <summery>
        /// Interact
        /// </summery>
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
