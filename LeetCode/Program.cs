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
        string s1 = "ab";
        string s2 = "eidbaooo";
        var leet = new LeetCode567();
        var ans = leet.CheckInclusion(s1,s2);
        Console.WriteLine(ans);
    }
   

    
}
