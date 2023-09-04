// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Hello, World!!");

using System.Xml.Schema;

namespace HelloWorld {

    public class Program {

        // SCOPE
        static int ClassInt = 8; // convention
        static string classString = "classString"; // to demonstrate scope

        static void Main(string[] args) {

            int classInt = 9;
            string classString = "methodString";


            Console.WriteLine(classInt);
            Console.WriteLine(classString);

            //// 1 byte is made up of 8 bits 00000000 - these bits can be used to store a number as follows
            // //// Each bit can be worth 0 or 1 of the value it is placed in
            // ////// From the right we start with a value of 1 and double for each digit to the left
            // //// 00000000 = 0
            // //// 00000001 = 1
            // //// 00000010 = 2
            // //// 00000011 = 3
            // //// 00000100 = 4
            // //// 00000101 = 5
            // //// 00000110 = 6
            // //// 00000111 = 7
            // //// 00001000 = 8
 
            // 1 byte (8 bit) unsigned, where signed means it can be negative
            // byte myByte = 255;
            // byte mySecondByte = 0;
 
            // // 1 byte (8 bit) signed, where signed means it can be negative
            // sbyte mySbyte = 127;
            // sbyte mySecondSbyte = -128;
 
 
            // // 2 byte (16 bit) unsigned, where signed means it can be negative
            // ushort myUshort = 65535;
 
            // // 2 byte (16 bit) signed, where signed means it can be negative
            // short myShort = -32768;
 
            // // 4 byte (32 bit) signed, where signed means it can be negative
            // int myInt = 2147483647;
            // int mySecondInt = -2147483648;
 
            // // 8 byte (64 bit) signed, where signed means it can be negative
            // long myLong = -9223372036854775808;
 
 
            // // 4 byte (32 bit) floating point number
            // float myFloat = 0.751f;
            // float mySecondFloat = 0.75f;
 
            // // 8 byte (64 bit) floating point number
            // double myDouble = 0.751;
            // double mySecondDouble = 0.75d;
 
            // // 16 byte (128 bit) floating point number
            // decimal myDecimal = 0.751m;
            // decimal mySecondDecimal = 0.75m;
 
            // Console.WriteLine(myFloat - mySecondFloat);
            // Console.WriteLine(myDouble - mySecondDouble);
            // Console.WriteLine(myDecimal - mySecondDecimal);
 
 
 
            // string myString = "Hello World";
            // // Console.WriteLine(myString);
            // string myStringWithSymbols = "!@#$@^$%%^&(&%^*__)+%^@##$!@%123589071340698ughedfaoig137";
            // // Console.WriteLine(myStringWithSymbols);
 
            // bool myBool = true;

            // string[] myStringArray = new string[3]{"one", "two", "three"};
            // int[] myIntArray = new int[3];
            // int anIntVariable = 3;

            // List<List<string>> myIntList = new List<List<string>>();

            // string name = "C# is a fun programming language";
            // string[] nameSplit = name.Split(" ");

            // IEnumerable<string> iEnumerableNameSplit = nameSplit;

            // Console.WriteLine(iEnumerableNameSplit.Count());

            // Console.WriteLine(1 == 2);
            // Console.WriteLine(DateTime.Now);

            // foreach(string value in nameSplit) {
            //     Console.WriteLine(value);
            // }

            // DateTime startTime = DateTime.Now;
            // DateTime currentTime = DateTime.Now;

            // TimeSpan timeDiff = currentTime - startTime;

            int[] intsArray = new int[]{1, 2, 3, 4, 5, 6, 7, 8};
            // string[] stringsArray = new string[] {};

            // foreach (int i in intArray){
            //     string iString = i.ToString();
            //     stringsArray.Append(iString);
            //     Console.WriteLine(iString);
            // }

            // Console.WriteLine(1.02343f + "i");

            
            DateTime startTime = DateTime.Now;

            int total = 0;
            foreach (int i in intsArray){
                
                total += i;

            }

            DateTime currentTime = DateTime.Now;

            TimeSpan timeDiff = currentTime - startTime;
            Console.WriteLine(timeDiff);

            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("");

            DateTime startTime2 = DateTime.Now;

            GetSum(intsArray);

            DateTime currentTime2 = DateTime.Now;

            TimeSpan timeDiff2 = currentTime2 - startTime2;
            Console.WriteLine(timeDiff2);


        }

        static public int GetSum(int[] intsArray){

            int total = 0;
            foreach (int i in intsArray){
                
                total += i;

            }

            return total;

        }
    }
}