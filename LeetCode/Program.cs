using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using LeetCode;
using NAudio.Dsp;
using NAudio.Wave;

class Program
{

    static void Main()
    {
        int[] sum = [0, 1, 1, 1, 1, 1, 0, 0, 0];
        var leet = new LeetCode525(sum);
        Console.WriteLine(leet);
    }
   

    
}
