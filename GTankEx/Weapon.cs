using System;
using System.Collections.Generic;
using System.Text;
 

namespace GTankEx
{
    public class Weapon : IAttack
    {
      
        public Weapon()
        {

        }
        public void Shoot(string target)
        {
            Console.WriteLine(target);
        }
    }
}

    
