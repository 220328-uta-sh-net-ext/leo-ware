using System;

    public class Practice2
    {
        /*
        Write a program in C# to find if given 2 strings are anagrams


        */
        //static string input1 = Console.ReadLine(s1);
        //static string input2 = Console.ReadLine(s2);

        public static bool Anagram(string s1, string s2)
        {
            /*
            1. Check the length of both strings.
            2. Sort the elements of each string in increasing order and compare them
            or Dictionary =>g 1
                            i 1
                            r 1
                            a 1
                            f 1
                            f 1
                            e 1
            */
            word1 = sortingString(s1); //StringToCharArray(S);
            word2 = sortingString(s2);

            if (word1.Length != word2.Length)
            {
                Console.WriteLine("Sorry. Your submission is not worthy.");
                return false;
                
            }
            else if (word1 == word2)
            {
                Console.WriteLine("Your submission is worthy");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry. Your submission is not worthy.");
                return false;
                //never put anything you want to be printed after a return statement!!
            }
            
            
            //for(i = 0; i < s2.Length; i++)
                //if (count[i] != 0)
                //{
                    //return false;
                //}
         
            //return true;
        }
        

        private static string sortingString(string s1)
        {

            string executedVariable = "";
            var wordArray = s1.ToCharArray;
            for (int i = 0; i < wordArray.Length; i++)
            {
                for (int j = 1; j < wordArray.Legnth; j++)
                {
                    if (System.Convert.ToInt32(wordArray[i]) > System.Convert.ToInt32(wordArray[j]))
                    {
                        var tempVariable = wordArray[i];
                        wordArray[i] = wordArray[j];
                        wordArray[j] = tempVariable;
                    }
                }
            }
           executedVariable = String(wordArray);
           return executedVariable;
            //string s1 = Console.ReadLine();
            
            //string s2 = Console.ReadLine();
            /*string[] words = Console.ReadLine().Split();
            int i;
            for (i = 0; i < N; i++)
            {
                s2[i] = Convert.ToInt32(words[i]);
            }
            
            
            Console.WriteLine(Anagram(s1,s2));*/
            //if (s1 == s2)
            //{
                //Console.WriteLine($"{s1}/n{s2}/nYour submission is worthy");
           //}
            //else
            //{
                //Console.WriteLine("Sorry. Your submission is not worthy.");
            //}
        }
       
        
    }
    //class morePractice
    //{
         /*public static bool Palindrome(string s)
        {
            /*
            1. Reverse the strings.
            2. Check if it is the similar.
            
        }*/
    //}
