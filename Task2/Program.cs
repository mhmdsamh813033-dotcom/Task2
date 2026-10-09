namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();

            string choise;
            
            do
            {
                Console.WriteLine(" Menu options : ");
                Console.WriteLine("P - Print numbers ");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("F - Find a number");
                Console.WriteLine("R - Remove a number");//bouns
                Console.WriteLine("C - Clear the list"); 
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("N - Display number of items");//bouns
                Console.WriteLine("O - Count the odd numbers");//bouns
                Console.WriteLine("E - Count the even numbers");//bouns
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("Q - Quit");

                 choise = (Console.ReadLine());

                 choise = choise.ToLower();

                switch (choise)
                {
                    case "p"://Print numbers
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("the list is empty");
                        }
                        else
                        {
                            Console.Write("[ ");
                            for (int i = 0; i < numbers.Count; i++)
                            {
                               
                                if (i > 0)
                                {
                                    Console.Write(" , ");
                                }

                                Console.Write(numbers[i]);
                            }
                            Console.WriteLine(" ]");
                        }

                        break;

                    case "a"://Add a number

                        Console.Write("Enter number to add to list : ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        numbers.Add(n);
                        Console.WriteLine("added ");

                        break;
                   
                    
                    case "f"://found index of the number 
                        Console.Write("Enter the number to find: ");
                        int target = Convert.ToInt32(Console.ReadLine());
                        bool found = false;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == target)
                            {
                                Console.WriteLine(target + " found at index " + i);
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                            Console.WriteLine(target + " not found");
                        break;


                    case "r"://remove number of the list & bouns
                        Console.Write("Enter the number to remove: ");
                        int numToRemove = Convert.ToInt32(Console.ReadLine());
                        if (numbers.Remove(numToRemove))
                            Console.WriteLine(numToRemove + " removed");
                        else
                            Console.WriteLine(numToRemove + " not found");
                        break;


                    case "c"://Clear the list 

                        numbers.Clear();
                        Console.WriteLine("List cleared");

                        break;

                    case "m"://Display mean of the numbers
                        if (numbers.Count != 0)
                        {
                            int sum = 0;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                sum = sum + numbers[i];
                            }
                            double mean = (double)sum / numbers.Count;
                            Console.WriteLine("Mean = " + mean);
                        }
                        else
                        {
                            Console.WriteLine("Unable to calculate the mean because the list is empty");
                        }

                        break;

                    case "n"://Display number of items & bouns

                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("the list is empty");
                        }
                        else
                        {
                            Console.WriteLine("number of list elements = " + numbers.Count);
                        }

                        break;


                    case "o"://count the odd numbers & bouns
                        List<int> odds = new List<int>();
                         for(int i=0;i<numbers.Count;i++)
                         {
                             if(numbers[i]%2!=0)
                                 {
                                     odds.Add(numbers[i]);
                                 }
                         }
                    Console.WriteLine("the count of odd numbers is  "+ odds.Count);
                       break;


                    case "e"://count the even numbers & bouns
                        List<int> evens = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                evens.Add(numbers[i]);
                            }
                        }    
                        Console.WriteLine("the count of even numbers is " + evens.Count);
                        break;


                    case "s"://Display the smallest number
                        if (numbers.Count == 0)
                            Console.WriteLine("Unable to determine the smallest number because list is empty");
                        else
                        {
                            int smallest = numbers[0];
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] < smallest)
                                {
                                    smallest = numbers[i];
                                }
                            }
                            Console.WriteLine("Smallest = " + smallest);
                        }
                        break;

                    case "l"://Display the largest number

                        if (numbers.Count == 0)
                            Console.WriteLine("Unable to determine the largest number because list is empty");
                        else
                        {
                            int largest = numbers[0];
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > largest)
                                {
                                    largest = numbers[i];
                                }
                            }
                            Console.WriteLine("Largest = " + largest);
                        }

                        break;

                    case "q"://quit the program

                        Console.WriteLine("Goodbye");

                        break;

                    default:
                        Console.WriteLine("invalid input , please try again");
                        break;
                }
            }

            while (choise != "q");
            

            }

        }
    }
