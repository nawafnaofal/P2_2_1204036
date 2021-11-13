using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204036
{
    public class MieGoreng 
    {
        private int hargaMie = 0;

        public void HargaMie(int buy)
        {

            hargaMie = Convert.ToInt32(buy * 25000);

        }
        public void output()
        {
            Console.WriteLine("Total Harganya : " + hargaMie);
        }

    }
}
