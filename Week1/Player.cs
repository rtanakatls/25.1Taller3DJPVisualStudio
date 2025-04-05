using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DJP251.Week1
{
    internal class Player
    {
        private string name;
        private int life;
        private int damage;

        public string Name { get { return name; } }
        public int Life { get { return life; } }
        public int Damage { get { return damage; } }

        public Player(string name, int life, int damage)
        {
            this.name = name;
            this.life = life;
            this.damage = damage;
        }

        public string GetData()
        {
            return $"Nombre: {name} - Vida: {life} - Daño: {damage}";
        }

        private void ChangeLife(int value)
        {
            life += value;
            if (life <= 0)
            {
                life = 0;
            }
            else if (life >= 100)
            {
                life = 100;
            }
        }

        public void TakePotion(int value)
        {
            ChangeLife(value);
        }

        public void TakeDamage(int value)
        {
            ChangeLife(-value);
        }
    }
}
