namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            do {
                Console.WriteLine("Choose a task:\n1) Task 1 (Calculator)\n2) Task 2 (Even/Odd)\n3) Task 3 (Find max)(\n4) Task 4 (1-10 Checker)\n5) Exit");
                Console.WriteLine("Enter your choice (1-5): "); 
                string choice = Console.ReadLine();

                switch (choice)
                {
                             case "1":
                        {

                            Console.WriteLine("Enter the first number: ");
                            double num1;
                            if (!double.TryParse(Console.ReadLine(), out num1))
                            {
                                Console.WriteLine("Invalid First Number!\nExiting task...");
                                break;
                            }
                            Console.WriteLine("Enter the second number: ");
                            double num2;
                            if (!double.TryParse(Console.ReadLine(), out num2))
                            {
                                Console.WriteLine("Invalid Second Number!\nExiting task...");
                                break;
                            }
                            Console.WriteLine("Enter the operator (+, -, *, /): ");
                            string op = Console.ReadLine();
                            switch (op)
                            {
                                case "+":
                                    Console.WriteLine("Sum: " + (num1 + num2));
                                    break;
                                case "-":
                                    Console.WriteLine("Sub: " + (num1 - num2));
                                    break;
                                case "*":
                                    Console.WriteLine("Mult: "+ (num1 * num2));
                                    break;
                                case "/":
                                    if (num2 == 0)
                                    {
                                        Console.WriteLine("Cannot divide by zero!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Div: " + (num1 / num2));
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Invalid operator! Exiting the task...");
                                    break;
                            }
                            }
                            break;
                             case "2":
                        {
                            Console.WriteLine("Enter a number: ");
                            int num;
                            if (!int.TryParse(Console.ReadLine(), out num))
                            {
                                Console.WriteLine("Invalid Number!\nExiting task...");
                                break;
                            }
                            if (num % 2 == 0)
                            {
                                Console.WriteLine("> The number is Even");
                            }
                            else
                            {
                                Console.WriteLine("> The number is Odd");
                            }
                        }
                                break;
                             case "3":
                        {
                            Console.WriteLine("Enter first number: ");
                            double num1;
                            if (!double.TryParse(Console.ReadLine(), out num1))
                            {
                                Console.WriteLine("Invalid First Number!\nExiting task...");
                                break;
                            }
                            double num2;
                            if (!double.TryParse(Console.ReadLine(), out num2))
                            {
                                Console.WriteLine("Invalid Second Number!\nExiting task...");
                                break;
                            }
                            if(num1 > num2)
                                Console.WriteLine("> " + num1 + " is the maximum");
                            else if(num2 > num1)
                                Console.WriteLine("> " + num2 + " is the maximum");
                            else
                                Console.WriteLine("> Both numbers are equal");
                        }

                                break;
                             case "4":
                        {
                            Console.WriteLine("Enter a number between 1 and 10: ");
                            int num;
                            if(int.TryParse(Console.ReadLine(), out num))
                            {
                                if(num >= 1 && num <= 10)
                                {
                                    Console.WriteLine("> Valid");
                                }
                                else
                                {
                                    Console.WriteLine("> Invalid");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid Number!\nExisiting task...");
                            }
                        }
                                break;
                            case "5":
                                Console.WriteLine("Exiting the program.");
                                return;
                            default:
                                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                                break;

                            }
                        
                } while (true) ;
        }
        }
    }


