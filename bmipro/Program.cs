namespace program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                //Console.Clear();
                headProgram("Pisit");
                //Input รับข้อมูล น้ำหนักและส่วนสูง
                double weight = 0.0;
                double height = 0.0;
                Console.Write("input your weight(kg) :");
                weight = Convert.ToDouble(Console.ReadLine());
                Console.Write("input your height(cm) :");
                height = Convert.ToDouble(Console.ReadLine());
                line("#", 40);
                //process ประกาศผล
                bmi(weight, height);
                line("%", 40);
                Console.Write("Do you want to calculate again? (y/n): ");
                choice = Console.ReadLine();

            }
            while (choice.ToLower() == "y");

            Console.WriteLine("Thank you for using the BMI calculator.");
        }

        static void line(string letter, int width)
        {
            string str = "";
            for (int i = 0; i < width; i++)
            {
                str += letter;
            }
            Console.WriteLine(str);
        }
        static void headProgram(string programgmerName)
        {
            Console.WriteLine("Bady mass index (EMI)");
            line("*", 40);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Green;

            Console.WriteLine("Develop by " + programgmerName);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            //WriteLineColor("Develop by " + programgmerName, ConsoleColor.Blue, ConsoleColor.White);
            //WriteLineColor("Udonthani Rajabhat University", ConsoleColor.Green, ConsoleColor.Black);

            line("-", 40);

            Console.WriteLine("Please input you Information");
        }
        static void WriteLineColor(string text, ConsoleColor fg, ConsoleColor bg)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bg;

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        static void bmi(double weight, double height)
        {
            //process ประกาศผล
            double bmi = weight / Math.Pow(height / 100, 2);
            string result = "";
            if (bmi < 18.5)
            {
                result = "Underweight";
            }
            else if (bmi < 25.0)
            {
                result = "Normal weight";
            }
            else if (bmi < 30)
            {
                result = "Overweight";
            }
            else
            {
                result = "obesity";
            }
            Console.WriteLine("Your Bady mass index (BMI) is " + bmi.ToString("0.00"));
            Console.WriteLine("From your bady mass index, you are " + result);
        }
    }
}
