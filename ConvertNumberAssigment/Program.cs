using Double = ConvertNumberAssigment.Double;
using Single = ConvertNumberAssigment.Single;
using Triple = ConvertNumberAssigment.Triple;
using Teen = ConvertNumberAssigment.Teen;

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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int ConvertToInt(string number)
        {
            
            if (int.TryParse(number, out int result)) return result;
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string ConvertToWord(string number ) {

            string toWord = "";
            
            int digit = DigitLength(number);
            if (digit == 4) {
                int firstDigit = ConvertToInt(number[0].ToString());
                int secondDigit = ConvertToInt(number[1].ToString());
                int thirdDigit = ConvertToInt(number[2].ToString());
                int fourthDigit = ConvertToInt(number[3].ToString());

                if (firstDigit > 0 && firstDigit <= 9)
                {
                    toWord = $"{(Single)firstDigit} {Triple.thousand}";
                }
                
                if (secondDigit > 0 && secondDigit <= 9)
                {
                    toWord += $" {(Single)secondDigit} {Triple.hundred}";
                }

                if (thirdDigit == 0)
                {
                    toWord += $" {(fourthDigit != 0 ? (Single)fourthDigit : "")}";
                }
                else if (thirdDigit == 1)
                {
                    toWord += $" {(fourthDigit == 0 ? (Single.ten) : (Double)fourthDigit - 1)}";
                }
                else
                {
                    toWord += $" {(Teen)thirdDigit - 2} - {(fourthDigit == 0 ? "" : (Single)fourthDigit)}";
                }


            }


            if (digit == 3) { 
            int oneNum = ConvertToInt(number[0].ToString());
            int twoNum = ConvertToInt(number[1].ToString());
            int threeNum = ConvertToInt(number[2].ToString());

             


                if (oneNum >0 && oneNum <= 10)
                {
                    toWord = $"{(Single)oneNum} {Triple.hundred}";  
                }

                if ( twoNum == 0)
                {
                    toWord += $" {(threeNum!=0 ?(Single)threeNum:"")}" ;
                }
                else if ( twoNum == 1) 
                {
                    toWord += $" {(threeNum==0?(Single.ten):(Double)threeNum-1)}";
                }
                else
                {
                    toWord += $" {(Teen)twoNum - 2}- {(threeNum==0?"":(Single)threeNum)}";
                }
               
            
            }

            if (digit == 2)
            {
                int firstDigit = ConvertToInt(number[0].ToString());
                int secondDigit = ConvertToInt(number[1].ToString());

                if (firstDigit == 0)
                {
                    toWord = $"{(Single)secondDigit}";
                }

                if (firstDigit == 1)
                {
                    toWord = $"{(Double)( firstDigit - 1)}";
                }
                else
                {
                    toWord += $"{(Teen)firstDigit - 2} {( secondDigit == 0 ? "" : (Single)secondDigit)}";
                }



            }

            if (digit == 1) {
            

                    int firstDigit = ConvertToInt(number[0].ToString());
                    toWord = $"{(Single)firstDigit }";
            }

            return toWord;
           
        }


        public static void Main(string[] args)
        {

            Console.WriteLine("Convert numbers to spoken words (text):\nCan only needs to support 4 digits.\nEnter the digit : ");
             string numberString = Console.ReadLine();

         


            Console.WriteLine(ConvertToWord(numberString));


           
                       

   
        }
    }
}