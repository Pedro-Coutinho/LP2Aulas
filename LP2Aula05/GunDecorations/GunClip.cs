using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public class GunClip : GunDecorator
    {
        public override int AmmoCapacity => base.AmmoCapacity + ammo;

        private int ammo;

        public GunClip (Gun tempgun, int ammo = 10) : base(tempgun)
        {

            if (ammo < 1 || ammo > 20)
            {
                throw new ArgumentOutOfRangeException(
                    "Ammo extension  must be between 1 and 20");
            }
            this.ammo = ammo;
        }
    }
}