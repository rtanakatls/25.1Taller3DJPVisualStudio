using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DJP251.Week1
{
    internal class MenuWeek1 : Menu
    {
        private Player player;
        public override void Execute()
        {
            player = GetPlayer();
            ShowMenu();            
        }

        private Player GetPlayer()
        {
            string name;
            int life;
            int damage;

            Console.WriteLine("Introduce tu nombre");
            name = Console.ReadLine();

            Console.WriteLine("Introduce tu cantidad de vida");
            life = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce tu cantidad de daño");
            damage = int.Parse(Console.ReadLine());

            return new Player(name, life, damage);
        }

        private void ShowMenu()
        {
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine(player.GetData());
                Console.WriteLine("1. Tomar poción (+10 vida)");
                Console.WriteLine("2. Agarrar el cactus con la mano (-5 vida)");
                Console.WriteLine("0. Salir");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        player.TakePotion(10);
                        ShowStatus();
                        break;
                    case "2":
                        player.TakeDamage(5);
                        ShowStatus();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("La opción no es válida");
                        break;
                }
            }
        }

        private void ShowStatus()
        {
            if (player.Life > 0)
            {
                Console.WriteLine("Aún estás vivo");
            }
            else
            {
                Console.WriteLine("Te moriste");
            }
        }

        private Enemy GetEnemy()
        {
            string name="";
            int damage=0;
            bool continueFlag = true;
            Enemy enemy=null;
            while (continueFlag)
            {
                Console.WriteLine("Introducir el nombre:");
                name = Console.ReadLine();
                Console.WriteLine("Introducir el daño:");
                damage = int.Parse(Console.ReadLine());
                if (damage > 0)
                {
                    enemy = new Enemy(name, damage);
                    continueFlag = false;
                }
                else
                {
                    Console.WriteLine("El daño no puede ser cero");
                }

            }
            return enemy;
        }

    }
}
