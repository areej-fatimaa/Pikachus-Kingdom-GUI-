﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace PacMan.GameGL
{
    interface IBullet
    {
        GameCell MoveBullet(GameDirection direction);
    }
}