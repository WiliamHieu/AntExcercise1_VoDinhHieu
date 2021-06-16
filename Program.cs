using System;
using System.Collections.Generic;

namespace AntExcercise1_VoDinhHieu
{
    class Program
    {
        public static List<Ant> CreateList()
        {
            List<Ant> antlist = new List<Ant>();
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                int temp = rnd.Next(1, 4);
                if (temp == 1)
                {
                    Worker worker = new Worker();
                    antlist.Add(worker);
                }
                if (temp == 2)
                {
                    Drone drone = new Drone();
                    antlist.Add(drone);
                }
                if (temp == 3)
                {
                    Queen queen = new Queen();
                    antlist.Add(queen);
                }
            }
            return antlist;

        }

        public static void ShowAntList(List<Ant> ants)
        {
            foreach (var item in ants)
            {
                Console.Write(item.Name + " | ");
                Console.Write(item.Health + " | ");
                Console.WriteLine(item.Status + " | ");
            }
        }

        static void Main(string[] args)
        {
        List<Ant> list = new List<Ant>();
            Console.WriteLine("-----ANT-----");
            Console.WriteLine("1. Create new ants list");
            Console.WriteLine("2. Damage ant");
            Console.WriteLine("3. Quit");
            Console.Write("Choose your option:");
            string response = Console.ReadLine();
            while (response != "3")
            {
                if (response == "1")
                {
                    list = CreateList();
                    ShowAntList(list);
                    Console.WriteLine("-----ANT-----");
                    Console.WriteLine("1. Create new ant lists");
                    Console.WriteLine("2. Damage ant");
                    Console.WriteLine("3. Quit");
                    Console.Write("Choose your option:");
                    response = Console.ReadLine();
                }
                if (response == "2")
                {
                    Random rnd = new Random();

                    foreach (var item in list)
                    {
                        int dmg = rnd.Next(0, 81);
                        item.Damage(dmg);

                    }
                    ShowAntList(list);
                    Console.WriteLine("-----ANT-----");
                    Console.WriteLine("1. Create new ant lists");
                    Console.WriteLine("2. Damage ant");
                    Console.WriteLine("3. Quit");
                    Console.Write("Choose your option:");
                    response = Console.ReadLine();
                }

            }
            return;
        }
    }        
}
