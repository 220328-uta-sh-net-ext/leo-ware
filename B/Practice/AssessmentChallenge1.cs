using System;


    public class AssessmentChallenge1
    {
        /*
        1. Navigate through the input array.
        2. Find the biggest number.

        */
        public static void safeCheck(int N,int[] A)
        {
            int result = "-404";
            int maxValue = Max(A);
            for (int i = 0; i < N; i ++)
            {
                int diff = maxValue - A[i];
                if (diff > 0)
                {
                    diff += 1;
                    Console.WriteLine(diff + " ");
                }
                else
                {
                    Console.WriteLine(diff + " ");
                }
                
            }
            //return result;
        }

        static int Max(int[] input)
        {
            int max = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] > max)
                max = input[i];
            }
        }

         public static void Main()
        {
            // INPUT [uncomment & modify if required]
            int N = Convert.ToInt32(Console.ReadLine());
            string S = Console.ReadLine();
            
            // OUTPUT [uncomment & modify if required]
            //Console.WriteLine(safeCheck(N,A));
            safeCheck(N,A);
        }
    }


