using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class DivideExeption : Exception
    {
               
            public DivideExeption(string message) : base(message)
            {
                 Console.WriteLine("FUCK!");
            }
        



    }
}
