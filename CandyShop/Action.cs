using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class Action
    {
        public bool CheckingIsInputNumber(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                     return false;
                }
            }

            return true;

        }
    }
}
