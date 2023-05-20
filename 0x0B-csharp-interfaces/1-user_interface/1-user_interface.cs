using System;

/// <summary>
/// Class Base
/// </summary>

abstract class Base
{
    /// <summary>
    /// The name of the object.
    /// </summary>
    public string name { get; set; }

    public override string ToString()
    {
        return $"{this.name} is a {this.GetType()}";
    }
}

public interface IInteractive
{
    void Interact();
}

public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact()
    {
    }

    public void Break()
    {
    }

    public void Collect()
    {
    }
}
