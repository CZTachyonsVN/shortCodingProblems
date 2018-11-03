using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// by Hai Horky
/// PROBLEM:
///     Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
///     For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
///     Bonus: Can you do this in one pass?
/// </summary>
namespace DailyCodingProblem1
{
    class Program
    {
        static void Main(string[] args) {
            int[] list = { 10, 3, 5, 7 }; //declare a list of numbers
            int k = 17; //target value

            Calc(list, k); //method call

            Console.ReadLine();
        }

        static bool Calc(int[] list, int k) { //method for calculation
            Array.Sort(list); //sort list of numbers ascending
            for (int i = 0, j = list.Length - 1; i < j;) { //i = lowest number, j = highest number; repeat as long as i < j;
                int sum = list[i] + list[j]; //sum of i + j
                Console.WriteLine(list[i] + " + " + list[j] + " = " + sum);
                if (sum < k) i++; // if the sum is smaller than the target value then use the next lowest number
                else if (sum > k) j--; //if the sum is bigger than the target value then use the next highest number
                else { Console.WriteLine("true"); return true; } //if the sum is equal to the target then return value 'true'              
            }
            Console.WriteLine("false");
            return false; //return value 'false'
        }
    }
}
