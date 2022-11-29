using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public abstract class Gun
    {
        public abstract int AmmoCapacity{get;}
        public abstract float NoiseLevel{get;}

        public virtual void Fire()
        {
            Console.WriteLine($"The weapon fired {AmmoCapacity}" + 
                              $"\nProducing {NoiseLevel} noise level");
        }
    }
}