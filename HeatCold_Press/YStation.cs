using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeatCold_Press
{
    public class YStation
    {
        public int y1 { get; set; }       // Number of pizza pans on CVX's bottom layer
        public int y2 { get; set; }         // 0: no pizza pan on CVX's top layer
                                                      // 1: have pizza pan on CVX's top layer
                                                      // 2: already take out silicon of pizza pan on CVX's top layer
    }
}
