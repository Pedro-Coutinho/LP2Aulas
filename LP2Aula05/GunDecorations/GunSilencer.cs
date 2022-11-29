using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GunDecorations
{
    public class GunSilencer : GunDecorator
    {

        public override float NoiseLevel => base.NoiseLevel * supression;

        private float supression;

        public GunSilencer (Gun gun, float percentage = 0.2f) : base(gun)
        {

            if (percentage < 0 || percentage > 1)
            {
                throw new ArgumentOutOfRangeException(
                    "Supression must be between 0 and 1");
            }
            supression = percentage;
        }

    }
}