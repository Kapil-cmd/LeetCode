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
        int[] num = { 1, 1, 1, 2, 2, 3 };
        int k = 2;
        var result = new LeetCode347();
        result.TopKFrequent(num,k);
        Console.WriteLine("The output is:",result);   
    }
   

    
}
