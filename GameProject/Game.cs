using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Game
    {
        
        public String GameName { get; set; }
        public float Price { get; set; }

        public static implicit operator Game(GameManager v)
        {
            throw new NotImplementedException();
        }
    }
}
