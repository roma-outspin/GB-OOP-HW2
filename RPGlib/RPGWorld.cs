using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGlib
{
    public class RPGWorld
    {
        public RPGWorld(): this (100,100, 2)
        {

        }

        public RPGWorld(int width, int height, int maxPlayers)
        {
            Width = width;
            Height = height;
            MaxPlayers = maxPlayers;
            Players = new List<Hero>();
        }

        public bool AddHero(Hero hero)
        {
            if(Players.Count<MaxPlayers)
            {
                Players.Add(hero);
                return true;
            } else
            {
                return false;
            }
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public int MaxPlayers { get; set; }
        public List<Hero> Players { get; set; }

        private bool isLive = false;

        public void Run()
        {

            isLive = true;
            while (isLive)
            {
                for(int i = 0; i < Players.Count;i++)
                {
                    if(i== Players.Count-1)
                    {
                        var rnd = new Random();
                        var weapon = rnd.Next(0, Players[0].Inventory.Count);
                        Players[i].Attack(Players[0], Players[0].Inventory[weapon]);

                    }
                    else
                    {
                        var rnd = new Random();
                        var weapon = rnd.Next(0, Players[i + 1].Inventory.Count);
                        Players[i].Attack(Players[i+1], Players[i + 1].Inventory[weapon]);
                    }

                    if (!Players[i].IsAlive)
                    {
                        Players.RemoveAt(i);
                    }

                    Task.Delay(1000);
                    if (Players.Count==1)
                    {
                        isLive = false;
                        Console.WriteLine($"Победил {Players[i].Name}");
                        break;
                    }
                }
            }
        }

    }
}
