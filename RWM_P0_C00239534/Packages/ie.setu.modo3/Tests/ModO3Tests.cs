using System.Collections;
using System.Collections.Generic;


using NUnit.Framework;
using UnityEngine;


namespace Tests
{
    public class ModO3FilterTest
    {
        [Test]
        public void ModO3Simple()
        {
            int[] input = { 10, 9, 12, 5, 5, 8 };
            int[] output = ModO3.Module3(input);
            int[] expected = { 1, 0, 0, 2, 2, 2 };

            CollectionAssert.AreEqual(expected, output);
        }
    }




}
