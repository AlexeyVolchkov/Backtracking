using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphGame
{
    class Chip
    {
        public Point point { get; set; }
        public bool isBlack { get; set; }

        public Chip(Point point, bool isBlack)
        {
            this.point = point;
            this.isBlack = isBlack;
        }
    }
}
