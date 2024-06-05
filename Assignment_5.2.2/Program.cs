/*
2. Write a program in C# Sharp to print the first n natural number using recursion.
Test Data :
How many numbers to print : 10
Expected Output :
1 2 3 4 5 6 7 8 9 10
*/

namespace Assignment_5._2._2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int printMaxValue = 10;
            int naturalNum = 1;
            
            RecursionOfDigit(naturalNum, printMaxValue);
         

        }       
       
        static void RecursionOfDigit(int naturalNum, int printMaxValue)
        {
            if (naturalNum <= printMaxValue)
            {
                Console.Write(naturalNum + " ");
                naturalNum += 1;
                RecursionOfDigit(naturalNum, printMaxValue);
            }
           
        }
    }
}
