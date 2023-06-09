using System;

/// <summary>
/// Represents a player with name, maximum health (maxHp), and current health (hp).
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class.
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


/// <summary>Determines the strength of attack modifer. </summary>
/// <param name="baseValue">Normal attack.</param>
/// <param name="modifier">Modifier to apply to baseValue.</param>
delegate float CalculateModifier(float baseValue, Modifier modifier);



class CurrentHPArgs : EventArgs
{
    public readonly float currentHp;

    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }


}