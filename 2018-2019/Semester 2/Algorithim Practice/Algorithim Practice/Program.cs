using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            do
            {


                Console.WriteLine("1 - Problem 1");
                Console.WriteLine("2 - problem 2");
                Console.WriteLine("3 - problem 3");
                Console.WriteLine("4 - Leave");

                answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        string text = AppDomain.CurrentDomain.BaseDirectory + @"Prob01.in.txt";
                        List<string> file = new List<string>();
                        using (StreamReader sr = new StreamReader(text))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                file.Add(line);
                            }
                        }
                        float beach = 0;
                        float ball = 0;
                        string amount = "";
                        for (int i = 0; i < file.Count; i++)
                        {
                            beach = 0;
                            if (file[i].Contains("QUARTER"))
                            {
                                amount = file[i].Substring(8);
                                beach = .25f * float.Parse(amount);
                            }
                            if (file[i].Contains("DIME"))
                            {
                                amount = file[i].Substring(5);
                                beach = .10f * float.Parse(amount);
                            }
                            if (file[i].Contains("NICKEL"))
                            {
                                amount = file[i].Substring(7);
                                beach = .05f * float.Parse(amount);
                            }
                            if (file[i].Contains("PENNY"))
                            {
                                amount = file[i].Substring(6);
                                beach = .01f * float.Parse(amount);
                            }
                            if (file[i].Contains("HALFDOLLAR"))
                            {
                                amount = file[i].Substring(11);
                                beach = .50f * float.Parse(amount);
                            }
                            ball = ball + beach;


                        }
                        Console.WriteLine("$" + ball);
                        Console.ReadLine();
                        break;

                    case 2:

                        string text2 = AppDomain.CurrentDomain.BaseDirectory + @"Prob02.in.txt";
                        List<List<string>> file2 = new List<List<string>>();
                        using (StreamReader sr = new StreamReader(text2))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                file2.Add(new List<string>());
                                string[] Arrays = line.Split(' ');
                                for (int i = 0; i < Arrays.Length; i++)
                                {
                                    file2[file2.Count - 1].Add(Arrays[i]);
                                }
                            }
                        }
                        for (int i = 0; i < file2.Count; i++)
                        {
                            bool isascending = true;
                            bool isdescending = true;
                            bool isvalid = true;
                            for (int j = 0; j < file2[i].Count - 1; j++)
                            {
                                int right = 0;
                                int left = 0;
                                if (!int.TryParse(file2[i][j], out left))
                                {
                                    Console.WriteLine("Invalid");
                                    isvalid = false;
                                    break;
                                }
                                if (!int.TryParse(file2[i][j + 1], out right))
                                {
                                    Console.WriteLine("Invalid");
                                    isvalid = false;
                                    break;
                                }
                                if (left < right)
                                {
                                    isdescending = false;
                                }
                                if (left > right)
                                {
                                    isascending = false;
                                }
                            }
                            if (isvalid == true)
                            {
                                if (isascending == false && isdescending == false)
                                {
                                    Console.WriteLine("Random");
                                }
                                else if (isdescending == true)
                                {
                                    Console.WriteLine("is descending");
                                }
                                else if (isascending == true)
                                {
                                    Console.WriteLine("is ascending");
                                }
                            }

                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        string text4 = AppDomain.CurrentDomain.BaseDirectory + @"Prob04.in.txt";
                        List<string> file3 = new List<string>();
                        using (StreamReader sr = new StreamReader(text4))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                file3.Add(line);
                            }
                        }
                        int temp = 0;
                        int total = 0;
                        for (int i = 0; i < file3.Count; i++)
                        {
                            temp = int.Parse(file3[i]);
                            total = temp;
                            temp -= 1;
                            while (temp > 0)
                            {
                                total = (total * temp);
                                temp--;
                            }
                            Console.WriteLine(total);
                        }
                        break;
                }
            } while (answer != 4);

        }
    }
}
