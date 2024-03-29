﻿using System;
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
