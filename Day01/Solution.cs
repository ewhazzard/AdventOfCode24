using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks.Dataflow;

namespace AdventOfCode24.Day01;
public class Solution{
    public static void PartOne(string input) {
        Console.WriteLine("Hello World!");
    }

    public static void PartTwo(string input){
        Console.WriteLine("Hello, world!");
    }

    public static void GetInput(string inputpath){
        StreamReader sr = new StreamReader(inputpath);
        String fileLine = sr.ReadLine();
        while (fileLine != null) {
            //write line to console
            Console.WriteLine(fileLine);
            //Read next line of the file
            fileLine = sr.ReadLine();

        }

    }
}