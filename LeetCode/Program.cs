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
        int[] nums = { 1,2,0 };
        var result = new LeetCode41();
        result.FirstMissingPositive(nums);
        Console.WriteLine("The output is:",result);   
    }
   

    
}
