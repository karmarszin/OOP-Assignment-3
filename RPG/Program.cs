using System;
namespace RPGApp;

class Program
{
    static void Main()
    {
        Hat hat = new Hat("Шляпа бесконечности", 50, 99);
		Armor vest = new Armor("Доспехи короля Артура", 43, 600);
		Weapon sword = new Weapon("Клинок, рассекающий демонов", 20, 60);
		Potion potion = new Potion("Целебная пилюля", 100);
        Console.WriteLine($"{hat.Name}: HP+{hat.Health}, rarity {hat.RarityLevel}");
		Console.WriteLine($"{vest.Name}: HP+{vest.Health}, rarity {vest.RarityLevel}");
		Console.WriteLine($"{sword.Name}: Attack+{sword.Attack}, rarity {sword.RarityLevel}");
		sword.ApplyPotion(potion);
		Console.WriteLine($"{sword.Name}: Attack+{sword.Attack}, rarity {sword.RarityLevel}");
    }
}