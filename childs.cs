using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{

    class Gun : Weapon
    {
        public Gun(int strength, int bulletQuantity) : base(strength, 80) 
        {
            BulletQuantity = bulletQuantity;
        }

        public int BulletQuantity { get; set; }

        public void GenerateBullet()
        {
            BulletQuantity += 10;
        }
    }

    class Dagger : Weapon
    {
        public Dagger(int strength, bool singleDagger) : base(strength, 90) 
        {
            SingleDagger = singleDagger;
        }

        public bool SingleDagger { get; set; }

        public void DoublePower()
        {
            Strength *= 2;
        }
    }

    class DualDagger : Dagger
    {
        public DualDagger(int strength) : base(strength, false)
        {
        }

        public new void DoublePower()
        {
            Strength *= 2;
        }
    }

    class Bow : Weapon
    {
        public Bow(int accuracy, int arrowQuantity) : base(accuracy, 70) 
        {
            ArrowQuantity = arrowQuantity;
        }

        public int ArrowQuantity { get; set; }

        public void GenerateArrowQuantity()
        {
            ArrowQuantity += 20;
        }
    }

    }
