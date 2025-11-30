namespace RPGApp;

public abstract class Item
{
    public string Name { get; set; }
    public virtual int RarityLevel { get; set; }

    public int Health { get; protected set; }
    public int Attack { get; protected set; }

    protected Item(string name, int rarityLevel = 1, int health = 0, int attack = 0)
    {
        Name = name;
        RarityLevel = rarityLevel;
        Health = health;
        Attack = attack;
    }

    public void ApplyPotion(Potion potion)
    {
        Health += potion.Power;
        Attack += potion.Power;
    }
}

public class Hat : Item
{
    public Hat(string name, int rarityLevel = 1, int health = 50)
        : base(name, rarityLevel, health, 0)
    {
    }
}

public class Armor : Item
{
    public Armor(string name, int rarityLevel = 1, int health = 500)
        : base(name, rarityLevel, health, 0)
    {
    }
}

public class Weapon : Item
{
    public Weapon(string name, int rarityLevel = 1, int attack = 35)
        : base(name, rarityLevel, 0, attack)
    {
    }
}

public class Potion
{
    public string Name { get; set; }
    public int Power { get; set; }

    public Potion(string name, int power)
    {
        Name = name;
        Power = power;
    }
}
