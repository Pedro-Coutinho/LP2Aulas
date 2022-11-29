using System;

namespace GunDecorations
{
    class Program
    {
        private Gun myGun;
        static void Main(string[] args)
        {
            myGun = new MachineGun(100, 60);

            myGun.Fire();
        }
    }
}
