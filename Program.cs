using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp74
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{VozvedenieNumber(2, 5)}");
            Console.ReadLine();
        }
        static int VozvedenieNumber(int number, int stepen)
        {
            int asd;
            int newDSA;
            int localnumber = number;
            for(int i = 0; i < stepen; i++)
            {
                number *= localnumber;
            }
            return number;
        } 
        static int VozvedenieKub(int number)
        {
            return number*number*number
        }
    }
}
