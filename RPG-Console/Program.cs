using System;
using RPGlib;

namespace RPG_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var Hero1 = new Warrior("Стрелок777");
            var Hero2 = new SharpShooter("Принцесса93");

            Hero1.X = 0;
            Hero1.Y = 0;
            Hero2.X = 10;
            Hero2.Y = 10;
            Hero1.Attack(Hero2, Hero1.Inventory[1]);
            Console.WriteLine($"{Hero1.Health.Level}, {Hero2.Health.Level}");

            var world = new RPGWorld();
            world.AddHero(Hero1);
            world.AddHero(Hero2);

            world.Run();
        }
    }
}
