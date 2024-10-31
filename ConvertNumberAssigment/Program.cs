
using ConvertNumberAssigment;
using Double = ConvertNumberAssigment.Double;
using Single = ConvertNumberAssigment.Single;

namespace ConvertNumberAssignment
{
   
    public class Program
    {
        /// <summary>
        /// the number of digit in the number
        /// </summary>
        /// <param name="number"></param>
        /// <returns>the legnth of the string</returns>
        public static int DigitLength(string number)
        {
            return number.Length;
        }

        public static int ConvertToInt(char number)
        {
            if (number == null) return 0;
            return Convert.ToInt32(number);
        }
        public static void ConvertToWord(string number ) {

            string toWord = "";
            
            int digit = DigitLength(number);
            if (digit == 3) { 
            int oneNum = ConvertToInt(number[0]);
            int twoNum = ConvertToInt(number[1]);
            int threeNum = ConvertToInt(number[2]);

                if (oneNum >= 0 && oneNum <= 10)
                {
                    toWord = $"{(Single)oneNum} {Triple.hundred}";  
                }

                if ( twoNum == 0)
                {
                    toWord += $" {(threeNum!=0 ?(Single)threeNum:"")}" ;
                }
                else if ( twoNum == 1) 
                {
                    toWord += $"{(threeNum==0?(Single.ten):(Double)threeNum-1)}";
                }
                else
                {
                    toWord += $"{(Teen)twoNum - 2}  {(threeNum==0?"":(Single)threeNum)}";
                }
               
            
            }
           



        }


        public static void Main(string[] args)
        {

            Console.WriteLine("Convert numbers to spoken words (text):\nCan only needs to support 4 digits.\nEnter the digit : ");
            string numberString = Console.ReadLine();
            //bool Isint = int.TryParse(numberString, out int number);
            //if (Isint)
            //{
            //    if (number >= 0 && number < 10)
            //    {
            //        Console.WriteLine((Single)number); 
            //    }else if (number >= 11 &&  number < 20)
            //    {
            //        Console.WriteLine((Double)number-11); 
            //    }

            //}


            Console.WriteLine($" number of digits {DigitLength(numberString)}  {numberString[1]}");
                       

   
        }
    }
}