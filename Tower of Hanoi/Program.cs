using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_of_Hanoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        } 
        static void Premakni (int n,string začetni, string končni, string pomožni)
        {
            //prestavi n obročev iz začetnega na končni
            if (n==1)
            {
                Console.WriteLine("Iz "+začetni+" na "+končni);
                return;
            }
            Premakni(n - 1, začetni, pomožni, končni);
            Console.WriteLine("Iz " + začetni + " na " + končni);
            Premakni(n - 1, pomožni, končni, začetni);
        }
    }
}
