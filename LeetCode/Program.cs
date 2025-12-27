using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using LeetCode;
using NAudio.Wave;

class Program
{

    static void Main()
    {
        LeetCode219 leetCode219 = new LeetCode219();
        var array = new int[] { 1, 2, 3, 1 };
        leetCode219.ContainsNearbyDuplicate(array, 3);
    }
   

    
}
