
using ConvertNumberAssigment;


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

            
            
            int digit = DigitLength(number);
            if (digit == 4) {
                int firstDigit = ConvertToInt(number[0].ToString());
                int secondDigit = ConvertToInt(number[1].ToString());
                int thirdDigit = ConvertToInt(number[2].ToString());
                int fourthDigit = ConvertToInt(number[3].ToString());

                return new ConvertLogic().Logic(firstDigit, secondDigit, thirdDigit, fourthDigit);

            }


            if (digit == 3) { 
            int oneNum = ConvertToInt(number[0].ToString());
            int twoNum = ConvertToInt(number[1].ToString());
            int threeNum = ConvertToInt(number[2].ToString());

             


               return  new ConvertLogic().Logic(oneNum,twoNum,threeNum);
               
            
            }

            if (digit == 2)
            {
                int firstDigit = ConvertToInt(number[0].ToString());
                int secondDigit = ConvertToInt(number[1].ToString());

                return new ConvertLogic().Logic(firstDigit, secondDigit);


            }

            if (digit == 1) {
            

                    int firstDigit = ConvertToInt(number[0].ToString());
                    return new ConvertLogic().Logic(firstDigit);
            }

            return $"The is no conversion for {number} for now";
           
        }


        public static void Main(string[] args)
        {

            Console.WriteLine("Convert numbers to spoken words (text):\nCan only needs to support 4 digits.\nEnter the digit : ");
             string numberString = Console.ReadLine();

         


            Console.WriteLine(ConvertToWord(numberString));


           
                       

   
        }
    }
}