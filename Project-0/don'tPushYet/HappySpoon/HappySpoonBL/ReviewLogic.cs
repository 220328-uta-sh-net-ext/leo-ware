using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HappySpoonDL;

namespace HappySpoonBL
{
    public class ReviewLogic
    {
       public static int Rating()
       {
            int rating;
            while (true)
            {
                Console.WriteLine("Choose a rating from 1 to 5,\n5 is the highest rating and 1 is the lowest rating");
                string input = Console.ReadLine();

                if (int.TryParse(input, out rating))
                {
                    if (rating >= 1 && rating <= 5)
                    {
                        Console.WriteLine($"You've rated this restaurant {rating} stars. Thank you for your feedback.");
                        return rating;
                    }
                    else
                        Console.WriteLine("We appreciate your enthusiasm,\nbut you may only give restaurants a rating from 1 to 5");  
                }
                else
                    Console.WriteLine("Your input was invalid. Please try entering a number.");
            }
       }

        public static void AverageRating(Restaurant)

    }
}
