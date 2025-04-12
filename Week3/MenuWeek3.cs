using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DJP251.Week3
{
    internal class MenuWeek3 : Menu
    {
        private List<Enemy> enemies;

        public MenuWeek3()
        {
            enemies=new List<Enemy>();
            enemies.Add(new EnemyRange());
            enemies.Add(new EnemyMelee());
            enemies.Add(new EnemyRange());
            enemies.Add(new EnemyMelee());
        }

        public override void Execute()
        {
            CreatePlayer();
            GameLogic();
        }

        private void CreatePlayer()
        {

        }

        private void GameLogic()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                PlayerTurn();
                if (EnemyIsAlive())
                {
                    EnemyTurn();
                    if (!PlayerIsAlive())
                    {
                        continueFlag = false;
                    }
                }
                else
                {
                    continueFlag = false;
                }
            }

            if(EnemyIsAlive())
            {
                Console.WriteLine("El jugador perdió");
            }
            else
            {
                Console.WriteLine("El jugador ganó");
            }
        }


        private void PlayerTurn()
        {

        }

        private bool PlayerIsAlive()
        {
            return true;
        }

        private void EnemyTurn()
        {

        }

        private bool EnemyIsAlive() 
        {
            return true;
        }

    }
}
