using ConsoleApp1Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SortStuff sorter = new SortStuff();
            List<int> aList = new List<int>();
            aList.Add(1);
            aList.Add(2);
            aList.Add(3);

            sorter.Reverse(aList);
        }
    }
}
