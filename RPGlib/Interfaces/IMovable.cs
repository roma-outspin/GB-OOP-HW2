using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGlib
{
    public interface IMovable
    {

        public void Move(MoveDirectionsX directionX, MoveDirectionsY directionY);
        
    }
}
