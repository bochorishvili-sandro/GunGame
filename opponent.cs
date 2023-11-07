using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Opponent
    {
        public int Hp { get; private set; }

        public Opponent(int health)
        {
            Hp = health;
        }

        public void TakeDamage(int damage)
        {
            Hp -= damage;
            if (Hp < 0)
            {
                Hp = 0;
            }
        }

        public bool AvoidAttack(int accuracy)
        {
            Random random = new Random();
            int chance = random.Next(1, 101);
            return chance <= accuracy - 30;
        }
    }



}
