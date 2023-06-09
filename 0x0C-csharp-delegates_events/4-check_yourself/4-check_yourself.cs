using System;

/// <summary>
/// Represents the arguments for the current HP event.
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// Gets the current HP value.
    /// </summary>
    public float CurrentHp { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CurrentHPArgs"/> class with the specified HP value.
    /// </summary>
    /// <param name="newHp">The new HP value.</param>
    public CurrentHPArgs(float newHp)
    {
        CurrentHp = newHp;
    }
}

/// <summary>
/// Represents a player with name, maximum health (maxHp), and current health (hp).
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;

    /// <summary>
    /// Gets the current health of the player.
    /// </summary>
    public float CurrentHp => hp;

    /// <summary>
    /// Occurs when the current HP is checked.
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class with the specified name and maximum health.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <param name="maxHp">The maximum health of the player.</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;

        if (maxHp > 0)
        {
            this.maxHp = maxHp;
        }
        else
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }

        this.hp = this.maxHp;
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
    }

    /// <summary>
    /// Prints the current health of the player.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    /// <summary>
    /// Applies damage to the player.
    /// </summary>
    /// <param name="damage">The amount of damage to be applied.</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }

        this.hp -= damage;
        Console.WriteLine($"{this.name} takes {damage} damage!");
        ValidateHP();
    }

    /// <summary>
    /// Heals the player.
    /// </summary>
    /// <param name="heal">The amount of health points to be healed.</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }

        this.hp += heal;
        Console.WriteLine($"{this.name} heals {heal} HP!");
        ValidateHP();
    }

    /// <summary>
    /// Validates and sets the new value of the Player's hp.
    /// </summary>
    private void ValidateHP()
    {
        if (this.hp < 0)
        {
            this.hp = 0;
        }
        else if (this.hp > this.maxHp)
        {
            this.hp = this.maxHp;
        }

        HPCheck?.Invoke(this, new CurrentHPArgs(hp));
    }

    /// <summary>
    /// Applies the modifier to the base value.
    /// </summary>
    /// <param name="baseValue">The base value.</param>
    /// <param name="modifier">The modifier.</param>
    /// <returns>The modified value.</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue / 2f;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                return baseValue;
        }
    }
    /// <summary>
/// Checks the status of the player based on the current HP.
/// </summary>
/// <param name="sender">The sender of the event.</param>
/// <param name="e">The event arguments containing the current HP value.</param>
private void CheckStatus(object sender, CurrentHPArgs e)
{
    if (e.CurrentHp == maxHp)
    {
        status = $"{name} is in perfect health!";
    }
    else if (e.CurrentHp >= maxHp / 2 && e.CurrentHp < maxHp)
    {
        status = $"{name} is doing well!";
    }
    else if (e.CurrentHp >= maxHp / 4 && e.CurrentHp < maxHp / 2)
    {
        status = $"{name} isn't doing too great...";
    }
    else if (e.CurrentHp > 0 && e.CurrentHp < maxHp / 4)
    {
        status = $"{name} needs help!";
    }
    else if (e.CurrentHp == 0)
    {
        status = $"{name} is knocked out!";
    }

    Console.WriteLine(status);
}

}

/// <summary>
/// The modifier values.
/// </summary>  
public enum Modifier
{
    /// <summary>
    /// Represents a weak modifier.
    /// </summary>
    Weak,

    /// <summary>
    /// Represents a base modifier.
    /// </summary>
    Base,

    /// <summary>
    /// Represents a strong modifier.
    /// </summary>
    Strong
}
/// <summary>delegate</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
