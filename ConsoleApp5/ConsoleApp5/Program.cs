using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,6,7,8,9,10 };
            int step = (int)Math.Sqrt(arr.Length - 1);
            int jump = step;
            int searchNum = 0;
            
            if(searchNum<=arr[arr.Length-1] && searchNum >= arr[0])
            {

                while (step < arr.Length)
                {

                    if (arr[step] == searchNum)
                    {

                        Console.WriteLine(step);
                        break;
                    }
                    if (arr[step] < searchNum)
                    {

                        step += jump;
                        if (step >= arr.Length)
                        {

                            int temp = step - jump;
                            if (temp < arr.Length - 1)
                            {
                                step += 1;
                            }
                            else
                            {

                                Console.WriteLine("-1");
                                break;
                            }

                        }
                    }

                    if (arr[step] > searchNum){

                        step -= 1;
                    }
                }
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
