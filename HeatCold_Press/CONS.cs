using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeatCold_Press
{
    public class CONS
    {
        public static int HeatPressTime = 40000;//ms
        public static int ColdPressTime = 30000;//ms
        public static int TimerInterval = 100;//ms

        public static List<string> RobotStep = new List<string>() { "E2", "B1", "A1", "D2", "E1", "B2", "A2", "D1" };
        public static int TotalStep = RobotStep.Count();
    }
}
