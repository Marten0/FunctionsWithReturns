using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero, villain;
            string heroWeapon, villainWeapon;
            hero = RandomHero();
            heroWeapon = RandomWeapon();
            villain = RandomVillain();
            villainWeapon = RandomWeapon();
            Console.WriteLine($"{hero} will fight {villain}");
            Console.WriteLine($"{hero} will fight with {heroWeapon}");
            Console.WriteLine($"{villain} will fight with {villainWeapon}");

        }

        private static int  RandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static string RandomHero()
        {
            string[] heroes = { "Batman", "Spongebob", "Spiderman", "Patrick", "Lara Croft" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, heroes.Length);


            return heroes[RandomIndex(heroes)];
            
        }

        private static string RandomVillain()
        {
            string[] villains = { "Joker", "Thanos", "Thief", "Darth Vader", "Loki" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villains.Length);

            string randomVillain = villains[randomIndex];
            return randomVillain;
        }

        private static string RandomWeapon()
        {
            string[] weapon = { "Frying Pan", "Plastic Knife", "Banana", "Katana", "Rope" };

            return weapon[RandomIndex(weapon)];
        }
    }
}
