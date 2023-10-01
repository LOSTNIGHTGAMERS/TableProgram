using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableProgram
{
    public class Table
    {
        public void Calculte(int tableNumber)
        {
            for (int i = 1; i <= 10; i++)
            {
                //Console.WriteLine($"{tableNumber} * {i} = {tableNumber * i}");
                Console.WriteLine(tableNumber + " * " + i + " = " + tableNumber * i);
            }
        }
    }
}
