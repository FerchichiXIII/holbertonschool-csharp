using System;

/// <summary>
/// Class Base
/// </summary>

public abstract class Base
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


/// <summary>
/// Ineterface Interactive
/// </summary>
public interface IInteractive {
    /// <summary>
    /// Intercat method
    /// </summary>
    void Interact();
}

/// <summary>
/// Interface Breakable
/// </summary>
public interface IBreakable {
    /// <summary>
    /// durability integer
    /// </summary>
    int durability {
        get;
        set;
    }
    /// <summary>
    /// break method
    /// </summary>
    void Break();   
}

/// <summary>
/// Interface Collectable
/// </summary>
public interface ICollectable {
    /// <summary>
    /// isCOllected property
    /// </summary>

    bool isCollected {
        get;
        set;
    }
    /// <summary>
    /// Collect method
    /// </summary>
    void Collect();
}

/// <summary>
/// Test object class
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable {

    /// <summary>
    /// durability property
    /// </summary>

    public int durability {
        get;
        set;
    }
    /// <summary>
    /// isCollected
    /// </summary>
    public bool isCollected {
        get;
        set;
    }

    /// <summary>
    /// Interact inmplementation
    /// </summary>
    public void Interact()
    {

    }

    /// <summary>
    /// Break implementation
    /// </summary>
    public void Break()
    {

    }

    /// <summary>
    /// COllect implementation
    /// </summary>
    public void Collect()
    {

    }
}