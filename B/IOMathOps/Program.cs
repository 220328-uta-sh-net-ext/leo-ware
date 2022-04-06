// See https://aka.ms/new-console-template for more information
namespace IOMathOps
{
    public class Mathematics
    {
        public static void Main() {
            Console.WriteLine("Please enter first number here: ");
            double num1, num2;
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();
            bool check1 = double.TryParse(input1, out num1);
            
            if (check1 == true) {
                Console.WriteLine("✔");
            }
            else {
                Console.WriteLine("Please enter an actual number. I don't have all day.");
            }
            Console.WriteLine("Please enter second number here: ");
            bool check2 = double.TryParse(input2, out num2);
            
            if (check2 == true) {
                Console.WriteLine ($"{num1} + {num2} = {num1 + num2}");
            }
            else {
                Console.WriteLine("Seriously? Ya fired.");
            }
        }
    }
}
