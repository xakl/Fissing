﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fissing.model
{
    class Serdines:Fish
    {
        public Serdines(int positionX, int positionY, int speed, PictureBox picture)
            : base(positionX, positionY, speed, picture)
        { }
    }
}
