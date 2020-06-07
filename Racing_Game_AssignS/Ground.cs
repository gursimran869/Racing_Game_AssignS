using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing_Game_AssignS
{
  public  class Ground: Better
    {
        Random obj = new Random();
        //generate the random no to move the rat 
        public int jump() {
            return obj.Next(1, 45);
        }
        //return the value of the finishing point to find the winner or stop the game 
        public int finishPoint() {
                return 690;
        }

    }
}
