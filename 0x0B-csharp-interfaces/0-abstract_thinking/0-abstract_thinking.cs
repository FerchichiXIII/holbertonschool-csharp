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
