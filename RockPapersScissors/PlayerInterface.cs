using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPapersScissors
{
   public interface PlayerInterface
    {
       Weapons chooseYourWeapon();

       string getBehavior();
    }
}
