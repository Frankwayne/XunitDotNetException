using ConsoleApp1Data;
using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            SortStuff sorter = new SortStuff();
            List<int> aList = new List<int>();
            aList.Add(1);
            aList.Add(2);
            aList.Add(3);
            var bList = sorter.Reverse(aList);

            bList.Should().ContainInOrder(new [] { 3,2,1});
        }
    }
}
