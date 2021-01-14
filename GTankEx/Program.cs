using System;

namespace GTankEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var canyon = new Weapon(); // Creamos las 3 armas 
            var machineGun = new Weapon();
            var machineGunAutomatic = new Weapon();
            Tank tank = new Tank(canyon, machineGun, machineGunAutomatic); // Creamos el tanque injectando por dependencia las 3 armas
            tank.Shoot("Disparar objetivo con las 3 armas");


        }
    }
}
