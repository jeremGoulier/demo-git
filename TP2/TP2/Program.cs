using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] tabLoto = new int[6];
            int tampon;
            Random toto = new Random();
            DateTime dateTirage = DateTime.Now;

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("*     ****            *     ****  *****  ****    ");
            Console.WriteLine("*     **              *     *  *    *    *  *    ");
            Console.WriteLine("****  ***             ****  ****    *    ****    ");
            Console.WriteLine("\nNous sommes le : " + dateTirage);

            for (int i = 0; i < 6; i++)
            {
                tampon = toto.Next(149);
                if(tabLoto.Contains(tampon)){
                    i = i - 1;
                }else{
                    tabLoto[i] = toto.Next(1,49);
                }
            }
            Console.WriteLine("\n" + tabLoto[0] + "  " + tabLoto[1] + "  " + tabLoto[2] + "  " + tabLoto[3] + "  " + tabLoto[4] + "  " + tabLoto[5]);
            Console.ReadKey(true);
        }
    }
}
