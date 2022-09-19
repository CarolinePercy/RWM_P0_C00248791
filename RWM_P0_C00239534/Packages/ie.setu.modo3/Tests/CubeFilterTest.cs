using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CubeFilterTest
    {
        [Test]
        public void CubeFilterSimple()
        {
            int[] input = { 10, 9, 12, 5, 5, 8 };
            int[] output = CubeFilter.Module3(input);
            int[] expected = { 1, 0, 0, 2, 2, 2 };

            CollectionAssert.AreEqual(expected, output);
        }
    }




}
