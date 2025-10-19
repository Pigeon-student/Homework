using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class InputExeption : Exception
    {
               
            public InputExeption(string message) : base(message)
            {
                 Console.WriteLine("Wrong input, try enter number!");
            }
        



    }
}
