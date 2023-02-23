using System;
internal class Program
{
    private static void Main(string[] args)
    {
        ProblemThree();
        ProblemTwo();
        ProblemFive();
        }
       static void ProblemTwo()
        {
            int input = 0;
            int total = 0;

            for (int i = 1; i > 0; i++)

            {
                Console.WriteLine("Please add an integer value less than 20");


                string test = Console.ReadLine()
                    .ToLower();

                if (test == "ok")
                {
                    break;
                }
                else
                {
                    input = int.Parse(test);
                    total = total + input;
                }

                Console.WriteLine(total);
            }
        }

       static void ProblemThree()
    {
        Console.WriteLine("Please enter a number and get the factorial of it");
		
		int number = int.Parse(Console.ReadLine());
    int factorial = 1;
		
		
		
		for(int i = 1 ; i<=number ; i ++)
		{
			factorial = factorial* i;
}

Console.WriteLine("{0}! : {1}", number, factorial);
}

static void ProblemFive()
        {
            
            {
                Console.Write("Enter a series of numbers, seperated by commas: ");

                var userInput = Console.ReadLine();

                var numbers = userInput.Split(',');

                var max = Convert.ToInt32(numbers[0]);

                foreach (var str in numbers)
                {
                    var number = Convert.ToInt32(str);
                    if (number > max)
                        max = number;
                }

                Console.WriteLine("Max is " + max);
            }








        }
    
}