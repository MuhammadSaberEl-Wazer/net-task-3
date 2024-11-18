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


        static int GetOccurance(int[] arr, int occNumberChecker)
        {
            int repetation = 0;
            if (arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                if(arr[i] == occNumberChecker) { repetation++; }
                }

            }

            return repetation;
        }

        static int[] ReverseArray(int[] sourceArr)
        {
            int newArrayLength = sourceArr.Length;
            int[] numbers = new int[newArrayLength];

            for (int i = 0; i < newArrayLength; i++)
            {
                int theNumber = sourceArr[newArrayLength - i - 1];
                numbers[i] = theNumber;

            }

            
            return numbers;
        }


        static void Main(string[] args)
        {
            #region
            //Task 1 

            //int inputOne, inputTwo;
            //string? sign = default;


            //Console.WriteLine("Hello, this is a calculator, pleaes enter first number");
            //inputOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("OK, pleaes enter second number");
            //inputTwo = Convert.ToInt32(Console.ReadLine());
            //do
            //{
            //    Console.WriteLine("Good, please select your process sign... (+,-,*,/)");
            //    sign = Console.ReadLine();

            //} while (!checkValidSign(sign));

            //if(sign == "+")
            //{
            //    Console.WriteLine(AddNumber(inputOne, inputTwo));
            //}else if(sign == "-")
            //{
            //    Console.WriteLine(MinusNumber(inputOne, inputTwo));
            //}else if (sign == "*")
            //{
            //    Console.WriteLine(MultiNumber(inputOne, inputTwo));
            //}else if (sign == "/")
            //{
            //    if (inputTwo != 0)
            //    {
            //        Console.WriteLine(DivideNumbers(inputOne, inputTwo));
            //    }
            //    else
            //    {
            //        bool validSecondNumber = false;
            //        do
            //        {
            //            Console.WriteLine("Ummm, 0 is not valid to divide on, please select another number");
            //            inputTwo = Convert.ToInt32(Console.ReadLine());

            //            if (inputTwo != 0)
            //            {
            //                validSecondNumber = true;
            //                Console.WriteLine(DivideNumbers(inputOne, inputTwo));
            //            }

            //        } while (!validSecondNumber);



            //    }

            //}


            //Console.WriteLine("Thank you for using calculator! ^_^");


            //End of Task 1 
            #endregion

            #region
            //int noOfOccToCheck, repetationCounter;
            //int[] arrayOfAll = { 1, 2, 3, 4, 5, 6, 7, 8, 9,5, 4, 1, 4, 2, 3, 4, 5, 6, 7, 8, 9, 4, 2, 4, 1, 8, 6, 5, 3, 9, 2, 5, 7, 3, 1, 5, 6, 7, 7, 9, 6, 9, 5, 3, 5, 6 };
            //Console.WriteLine("Hello sir, I've an array you show it and if you wanna check ocuurance of a number in it please type the number...");
            //for (int j = 0; j < arrayOfAll.Length; j++)
            //{
            //    Console.WriteLine(arrayOfAll[j]);
            //}
            //Console.WriteLine("Which number you wanna check please?");
            //noOfOccToCheck = Convert.ToInt32 (Console.ReadLine());

            //repetationCounter = GetOccurance(arrayOfAll, noOfOccToCheck);

            //Console.WriteLine($"Occurance of number you wrote is/are {repetationCounter} time/times, Thank you ^_^");
            #endregion


            #region
            //Task 3

            int[] sourceArray = { 5, 4, 3, 2, 1, 0 , -1,-2};
            Console.WriteLine("Old numbers are..");
            for (int i = 0; i < sourceArray.Length; i++)
            {
                Console.WriteLine(sourceArray[i]);
            }
            int[] newArray = ReverseArray(sourceArray);
            Console.WriteLine("--------- REVERSING ----------");
            Console.WriteLine("New numbers are..");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }



            #endregion
        }

    }
}
