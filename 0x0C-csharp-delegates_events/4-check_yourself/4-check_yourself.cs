using System;


/// <summary>
/// Represents a player with name, maximum health (maxHp), and current health (hp).
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status = "Player is ready to go!";

    /// <summary>
    /// Event triggered when the player's current health is checked.
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

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

        HPCheck?.Invoke(this, new CurrentHPArgs(this.hp));
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

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        float currentHp = e.currentHp;

        if (currentHp == maxHp)
        {
            status = $"{name} is in perfect health!";
        }
        else if (currentHp >= maxHp / 2 && currentHp < maxHp)
        {
            status = $"{name} is doing well!";
        }
        else if (currentHp >= maxHp / 4 && currentHp < maxHp / 2)
        {
            status = $"{name} isn't doing too great...";
        }
        else if (currentHp > 0 && currentHp < maxHp / 4)
        {
            status = $"{name} needs help!";
        }
        else if (currentHp == 0)
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

/// <summary>
/// Represents the arguments for the current HP event.
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// The current HP value.
    /// </summary>
    public float currentHp;

    /// <summary>
    /// Initializes a new instance of the <see cref="CurrentHPArgs"/> class with the specified current HP value.
    /// </summary>
    /// <param name="currentHp">The current HP value.</param>
    public CurrentHPArgs(float currentHp)
    {
        this.currentHp = currentHp;
    }
}
