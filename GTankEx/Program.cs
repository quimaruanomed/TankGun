using System;

namespace GTankEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var weapon1 = new Weapon(); // Creamos las 3 armas 
            var weapon2 = new Weapon();
            var weapon3 = new Weapon();
            Tank tank = new Tank(weapon1, weapon2, weapon3); // Creamos el tanque injectando por dependencia las 3 armas
            tank.Shoot("Disparar objetivo con las 3 armas"); 

        }
    }
}
