using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1Data
{
    public class SortStuff
    {
        public IEnumerable<T> Reverse<T>(IEnumerable<T> input)
        {
            return input.Reverse().ToArray();
        }
        
    }
}
