﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tako.Sorting;
using Xunit;
namespace Tako.Sorting.Tests
{
    public class MergeSortTests
    {
        private int count = 10000;
        private readonly int[] testInts;
        private Random random = new Random();

        public MergeSortTests()
        {
            this.testInts = new int[this.count];

            for (int i = 0; i < this.count; i++)
            {
                this.testInts[i] = this.random.Next();
            }
        }

        [Fact()]
        public void SortTest()
        {
            MergeSort<int> sort = new MergeSort<int>();
            int[] copy = new int[this.count];

            this.testInts.CopyTo(copy, 0);
            sort.Sort(copy);

            for (int i = 0; i < copy.Length - 1; )
            {
                Assert.True(copy[i] <= copy[++i]);
            }
        }
    }
}