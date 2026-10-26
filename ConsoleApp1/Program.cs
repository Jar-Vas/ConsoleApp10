namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            Console.WriteLine("Task1");
            Console.WriteLine("Choose (A/B): ");
            string s = Console.ReadLine();
            if (s == "A")
            {
                Console.Write("Input integer: ");
                if (int.TryParse(Console.ReadLine(), out int num1))
                {
                    Console.WriteLine("Out: " + toBin(num1));
                }
                else
                {
                    Console.WriteLine("Idk");
                }
            }
            else if (s == "B")
            {
                Console.Write("Input bin integer: ");
                string s1 = Console.ReadLine();
                Console.WriteLine("Out: " + toLong(s1));
            }
            #endregion 1


            #region 2
            Console.WriteLine("Task2");
            string[] numbers = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            Console.Write("Input integer (0 to 9): ");
            if (int.TryParse(Console.ReadLine(), out int num2))
            {
                if (0 <= num2 && num2 <= 9)
                {
                    Console.WriteLine(num2 + ": " + numbers[num2]);
                }
                else
                {
                    Console.WriteLine("Idk");
                }
            }
            else
            {
                Console.WriteLine("Idk");
            }


            #endregion 2


            #region 4
            Console.WriteLine("Task4");
            Console.WriteLine("Input: ");
            string s4 = Console.ReadLine();
            int index = 0;
            string temp = "<>+!=";
            for (int i = 0; i < s4.Length; i++)
            {
                foreach (char j in temp)
                {
                    if (s4[i] == j)
                    {
                        index = i; break;
                    }
                }
                if (index != 0)
                {
                    break;
                }
            }
            bool k = false;
            int.TryParse(s4.Substring(0, index), out int n41);
            if (!char.IsDigit(s4[index + 1])) { index++; k = true; }
            int.TryParse(s4.Substring(index+1, s4.Length-index-1), out int n42);

            if (k)
            {
                if (s4[index-1] == '<')
                {
                    Console.Write("Ans: " + (n41 <= n42));
                }
                else if (s4[index - 1] == '>')
                {
                    Console.Write("Ans: " + (n41 >= n42));
                }
                else if (s4[index - 1] == '=')
                {
                    Console.Write("Ans: " + (n41 == n42));
                }
                else if (s4[index - 1] == '!')
                {
                    Console.Write("Ans: " + (n41 != n42));
                }
            }
            else
            {
                if (s4[index] == '<')
                {
                    Console.Write("Ans: " + (n41 < n42));
                }
                else if (s4[index] == '>')
                {
                    Console.Write("Ans: " + (n41 > n42));
                }
            }

            #endregion 4

        }

        static long power(long a, long b)
        {
            long ans = 1;
            for (int i = 0; i < b; i++)
            {
                ans *= a;
            }
            return ans;            
        }
        static string toBin(long num)
        {
            string s = "";
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    s += "0";
                }
                else
                {
                    s += "1";
                }
                num /= 2;
            }
            return s;
        }

        static long toLong(string s)
        {
            long num = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (int.TryParse(s[i].ToString(), out int n))
                {
                    num += n * power(2, s.Length - i - 1);
                    if (num > int.MaxValue)
                    {
                        throw new Exception("int: Idk");
                    }
                }
                else
                {
                    throw new Exception("Idk");
                }
            }
            return num;
        }
    }
}
