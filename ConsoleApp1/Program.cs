namespace ConsoleApp1
{
    internal class Program



    {

        static int AddNumber(int no1, int no2)
        {
            return no1 + no2;
        }
        static int MinusNumber(int no1, int no2)
        {
            return no1 - no2;
        }

        static int MultiNumber(int no1, int no2)
        {
            return no1 * no2;
        }
        static double DivideNumbers(int no1, int no2)
        {
            return (double)no1 / no2;
        }
         
        static bool checkValidSign(string theSign)
        {
            if(theSign == "+" || theSign == "-" || theSign == "*" || theSign == "/")
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        static void Main(string[] args)
        {
            #region
            //Task 1 

            int inputOne, inputTwo;
            string? sign = default;


            Console.WriteLine("Hello, this is a calculator, pleaes enter first number");
            inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("OK, pleaes enter second number");
            inputTwo = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Good, please select your process sign... (+,-,*,/)");
                sign = Console.ReadLine();

            } while (!checkValidSign(sign));

            if(sign == "+")
            {
                Console.WriteLine(AddNumber(inputOne, inputTwo));
            }else if(sign == "-")
            {
                Console.WriteLine(MinusNumber(inputOne, inputTwo));
            }else if (sign == "*")
            {
                Console.WriteLine(MultiNumber(inputOne, inputTwo));
            }else if (sign == "/")
            {
                if (inputTwo != 0)
                {
                    Console.WriteLine(DivideNumbers(inputOne, inputTwo));
                }
                else
                {
                    bool validSecondNumber = false;
                    do
                    {
                        Console.WriteLine("Ummm, 0 is not valid to divide on, please select another number");
                        inputTwo = Convert.ToInt32(Console.ReadLine());

                        if (inputTwo != 0)
                        {
                            validSecondNumber = true;
                            Console.WriteLine(DivideNumbers(inputOne, inputTwo));
                        }
                        
                    } while (!validSecondNumber);



                }

            }


            Console.WriteLine("Thank you for using calculator! ^_^");


            //End of Task 1 
            #endregion
        }

    }
}
