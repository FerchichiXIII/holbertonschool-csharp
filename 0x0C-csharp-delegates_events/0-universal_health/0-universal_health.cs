using System;

public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    public Player(string name = "Player", float maxHp = 100f )
    {
        this.name = name;
        if (maxHp > 0)
        {
            this.name = name;
            this.maxHp = maxHp;
        }
        else
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.name = name;
            this.maxHp = 100f;
        }

        this.hp = this.maxHp;
        this.maxHp = this.maxHp;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}   