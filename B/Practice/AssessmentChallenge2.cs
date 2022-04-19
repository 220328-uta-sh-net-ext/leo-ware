using System;
    public class AssessmentChallenge2
    {
        public static string secretWord(int N, string S)
    {
        string result = "-404";

        /*
            1. Get all the alphabets some position
                        char[] allLetter = 'a', 'b'...., 'z';
            2. Navigate through input string
                        -convert your string to array of characters
            3. Use switch case to swap the characters
            or use dictionary to swap th characters
            or ASCII
            or find a pattern to swap the characters =>
                    length of allLetter array - 1 - position (index) of the character of that string in the allLetters array.
            4. print results;
        */

        //char[] alphabetForwards {};
        //char[] alphabetForwards {"a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z"};
        char[] inputStr = S.ToCharArray(S); //StringToCharArray(S);
        for (int i = 0; i < N; i++)
        {
           // int index = Array.IndexOf(alphabetForwards, inputStr[i]);
           int index = alphabetForwards.IndexOf(inputStr[i]);
            //inputStr[i] = alphabetForwards[alphabetForwards.Length - 1 - index];

            //result = new string(inputStr);
            //return result;
            result += alphabetForwards[alphabetForwards.Length - 1 - index];
        }
        return result;

    }
// You can also delete the method below and assign this line of code to char[] : S.ToCharArray();
    public static char[] StringToCharArray(string str)
    {
        /*if (str.IsNullorEmpty(str)) 
        {
            //char[] arr = new char[str.Length];
            return null;
        }
        else
        {
            char[] arr = new char[str.Length];
        }*/
        
        char[] arr = new char[str.Length];
        if (str.IsNullorEmpty(str)) 
        {
            for (int i=0; i < str.Length; i++)
            {
                arr[i] = str[i];
            }
        }

    }

    public static void Main()
    {
        // INPUT [uncomment & modify if required]
        int N = Convert.ToInt32(Console.ReadLine());
        
        int[] A = new int[N];
        string[] tokens = Console.ReadLine().Split();
        int i;
        for (i = 0; i < N; i++)
        {
            A[i] = Convert.ToInt32(tokens[i]);
        }
        
        // OUTPUT [uncomment & modify if required]
        Console.WriteLine(safeCheck(N,A));
    }
    }
