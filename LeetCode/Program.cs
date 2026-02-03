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
        int[] nums = [1, 3, -1, -3, 5, 3, 6, 7];
        int k = 3;
        var leet = new LeetCode239();
        var ans = leet.MaxSlidingWindow(nums,k);
        Console.WriteLine(ans);
    }
   

    
}
