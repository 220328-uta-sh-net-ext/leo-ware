// See https://aka.ms/new-console-template for more information
using System;
namespace IOMathOps
{
    public class Mathematics
    {
        public static void Main() {
            Console.WriteLine("Please enter first number: ");
            double num1, num2, num3, num4, num5, num6;
            var input1 = Console.ReadLine();
            bool check1 = double.TryParse(input1, out num1);
          
            
            if (check1 == true) {
                    //Console.WriteLine("✔");
                Console.WriteLine("Thank you ^-^");
                Console.WriteLine("Please enter second number: ");
            }
            if (check1 == false) {
                Console.WriteLine("Please enter an actual number. I don't have all day:");
                var input2 = Console.ReadLine();
                bool check2 = double.TryParse(input2, out num2);

                    if (check2 == true) {
                        Console.WriteLine("Thank you ^-^");
                        Console.WriteLine("Please enter second number: ");
                        var input3 = Console.ReadLine();
                        bool check3 = double.TryParse(input3, out num3);
                            if (check3 == false) {
                                Console.WriteLine("Please enter an actual number. I don't have all day:");
                                var input4 = Console.ReadLine();
                                bool check4 = double.TryParse(input4, out num4);
                                    if ((check1 == true) && (check4 == true)) {
                                        Console.WriteLine("Calculating results...");
                                        Console.WriteLine ($"{num1} + {num4} = {num1 + num4}");
                                        Console.WriteLine ("Thanks for visiting! I hope you have a wonderful day!");
                                    }
                                    if ((check2 == true) && (check4 == true)) {
                                        Console.WriteLine("Calculating results...");
                                        Console.WriteLine ($"{num2} + {num4} = {num2 + num4}");
                                        Console.WriteLine ("Thanks for visiting! I hope you have a wonderful day!");
                                    }
                                    /*if (check4 == false) {
                                        Console.WriteLine("Wow.... \nYou might actually be two monkies short of a barrel.");
                                    }*/
                                    if (check4 == false) {
                                        Console.WriteLine("Nope. -_- Let's try this one last time. \nPlease enter first number:");
                                        var input5 = Console.ReadLine();
                                        bool check5 = double.TryParse(input5, out num5);
                                            if (check5 == true) {
                                                Console.WriteLine("Thank you ^-^");
                                                Console.WriteLine("Please enter second number: ");
                                                var input6 = Console.ReadLine();
                                                bool check6 = double.TryParse(input6, out num6);

                                                    if ((check5 == true) && (check6 == true)) {
                                                        Console.WriteLine("Calculating results...");
                                                        Console.WriteLine ($"{num5} + {num6} = {num5 + num6}");
                                                        Console.WriteLine ("Thanks for visiting! I hope you have a wonderful day!");
                                                    }
                        
                                                    else /*(check5 == false)*/ {
                                                        Console.WriteLine("Seriously?! Ya fired! D:<");
                                                    }
                                            }
                                    }
                            }
                    }     
                            
                }
                    else if ((check1 == true) && (check3 == true)) {
                        Console.WriteLine("Calculating results...");
                        Console.WriteLine ($"{num1} + {num3} = {num1 + num3}");
                        Console.WriteLine ("Thanks for visiting! I hope you have a wonderful day!");
                    }
                    else if ((check2 == true) && (check3 == true)) {
                        Console.WriteLine("Calculating results...");
                        Console.WriteLine ($"{num2} + {num3} = {num2 + num3}");
                        Console.WriteLine ("Thanks for visiting! I hope you have a wonderful day!");
                    }
                    else {
                        Console.WriteLine("Wow.... \nYou might actually be two monkies short of a barrel.");
                    }
            }
            /*else {
                Console.WriteLine("Wow.... \nYou might actually be two monkies short of a barrel.");
            }*/
            
            
            //else {
                //Console.WriteLine("Wow.... \nYou might actually be two monkies short of a barrel.");
            //}    
            

            
                
            

            
            

            

            
            
                
                
            
            

            /*if ((check1 == false) && (check2 == false) && (check3 == false) && (check4 == false)) {
                Console.WriteLine("Nope. -_- Let's try this one last time. \nPlease enter first number:");
                var input5;
                bool check5;
                    if (check5 == true) {
                        Console.WriteLine("Thank you ^-^");
                        Console.WriteLine("Please enter second number: ");
                        var input6;
                        bool check6;

                        if ((check5 == true) && (check6 == true)) {
                            Console.WriteLine("Calculating results...");
                            Console.WriteLine ($"{num5} + {num6} = {num5 + num6}");
                            Console.WriteLine ("Thanks for visiting! I hope you have a wonderful day!");
                        }
                        
                        else //check5 == false)// {
                            Console.WriteLine("Seriously?! Ya fired! D:<");
                        }
                    }
            }*/
                    

                //Console.WriteLine();
                //Console.WriteLine();

            
            /*if ((check3 == false) && (check4 == false)) {
                Console.WriteLine("Seriously?! Ya fired! D:<");
            }

            if ((check == true) && (check1 == true)) {
                Console.WriteLine("Calculating results...");
            Console.WriteLine ($"{num1} + {num3} = {num1 + num3}");
            Console.WriteLine ("Thanks for visiting! I hope you have a wonderfule day!");
            }*/
        }
    }
}
