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
/// <summary>
/// test object class inherit from interfaces and obstact class
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// property 
    /// </summary>
    public int durability { get; set; }
    /// <summary>
    /// isCollected
    /// </summary>
    public bool isCollected { get; set; }
    /// <summary>
    /// Break
    /// </summary>
    public void Break()
    {

    }
    /// <summary>
    /// Collect
    /// </summary>
    public void Collect()
    {

    }
    /// <summary>
    /// Interact
    /// </summary>
    public void Interact()
    {

    }
}