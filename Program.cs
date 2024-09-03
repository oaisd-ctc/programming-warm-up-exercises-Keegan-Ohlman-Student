using System;

namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the Main method to test your functions.
            Console.WriteLine(Add(5, 10));
            Console.WriteLine(IsEven(10));
            Console.WriteLine(MaxOfThree(1, 12, 5));
            Console.WriteLine(StringLength("Worlds"));
            Console.WriteLine(StartsHello("Hello World"));
            Console.WriteLine(ReverseString("Hello"));
            Console.WriteLine(Factorial(8));
            Console.WriteLine(Fibonacci(17));
            int[] test = {19, 5, 10, 35, 35};
            Console.WriteLine(LargestInArray(test));
            Console.WriteLine(IsPalindrome("Racecar"));
            Console.WriteLine(ArraySum(test));
            Console.WriteLine(CharCount("HelLoWorld", 'l'));
            Console.WriteLine(ConcatenateStrings("Hello", "World"));
            Console.WriteLine(SwapEnds("Hello"));
        }

        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 3. Return the largest of three numbers.
        public static int MaxOfThree(int a, int b, int c)
        {
            int d = Math.Max(a, b);
            int e = Math.Max(c, d);
            return e;
        }

        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {
            int length = s.Length;
            return length;
        }

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
            bool x = s.StartsWith("Hello");
            return x;
        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // 7. Return the factorial of a number.
        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            for(int i = n - 1; i >= 1; i--)
            {
               n *= i;
            }
            return n;
        }

        // 8. Check if a number is a prime number.
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            // TODO: Return the correct boolean value.
            return false;
        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        // 10. Given an array of integers, return the largest number.
        public static int LargestInArray(int[] numbers)
        {
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            return largest;
        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {
            string x = s.ToLower();
            char[] chars = x.ToCharArray();
            Array.Reverse(chars);
            string backward = new string(chars);
            
            if(backward == x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            string x = s.ToLower();
            int count = 0;
            char[] chars = x.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if(chars[i] == c)
                {
                    count++;
                }
            }
            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            string str3 = str1 + " " + str2;
            return str3;
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            if (s.Length <= 1) return s;
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            string temp1 = Char.ToString(lastChar);
            string temp2 = Char.ToString(firstChar);
            s = s.Remove(0, 1).Insert(0, temp1);
            s = s.Remove(s.Length - 1, 1).Insert(s.Length - 1, temp2);
            
            return s;
        }
    }
}
