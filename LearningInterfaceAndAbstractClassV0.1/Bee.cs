using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaceAndAbstractClassV0._1
{
    public class Bee : IStingPatrol //We have to set up all methods and fields and decalere them as public. Now program should complie properly, even if it does nothing.
    {
        public int AlertLevel
        {
            get
            {
                return 5;
            }
        }
       public int StingerLength
        {
            get
            {
                int x = 5;
                return x;
            }
            set
            {
                int x = 10;
            }
        }

       public bool LookForEnemies()
        {
            return true;
        }

        public int SharpenStinger(int Length)
        {
            int x = 5;
            x = Length;
            return Length;
        }
    }
}
