using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204036
{
    public class Nasgor 
    {
        private int hargaNas = 0;
        
        public void HargaNas(int buy)
        {

            hargaNas = Convert.ToInt32(buy*12000);

        }
        public void output() //method untuk menampilkan hasil dari proses method HargaNas
        {
            Console.WriteLine("Total Harganya : " + hargaNas);
        } 
            
    }
}
