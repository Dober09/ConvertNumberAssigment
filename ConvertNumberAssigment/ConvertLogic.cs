
using System;

namespace ConvertNumberAssigment
{
    public class ConvertLogic
    {
        private string? toWord;


        /// <summary>
        /// This method converts the numbers to words 
        /// </summary>
        /// <param name="firstDigit"></param>
        /// <param name="secondDigit"></param>
        /// <param name="thirdDigit"></param>
        /// <param name="fourthDigit"></param>
        /// <returns> string of words</returns>
        public  string Logic(int firstDigit, int secondDigit , int thirdDigit, int fourthDigit)
        {
         

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

            return this.toWord ;

        }
        /// <summary>
        /// This method converts the numbers to words 
        /// </summary>
        /// <param name="firstDigit"></param>
        /// <param name="secondDigit"></param>
        /// <param name="thirdDigit"></param>
        /// <returns></returns>
        public string Logic(int firstDigit, int secondDigit , int thirdDigit)
        {

            if (firstDigit > 0 && firstDigit <= 10)
            {
                toWord = $"{(Single)firstDigit} {Triple.hundred}";
            }

            if (secondDigit == 0)
            {
                toWord += $" {(thirdDigit != 0 ? (Single)thirdDigit : "")}";
            }
            else if (secondDigit == 1)
            {
                toWord += $" {(thirdDigit == 0 ? (Single.ten) : (Double)thirdDigit - 1)}";
            }
            else
            {
                toWord += $" {(Teen)secondDigit - 2}- {(thirdDigit == 0 ? "" : (Single)thirdDigit)}";
            }

            return this.toWord ;

        }

        /// <summary>
        /// This method converts the numbers to words 
        /// </summary>
        /// <param name="firstDigit"></param>
        /// <param name="secondDigit"></param>
        /// <returns></returns>
        public string Logic(int firstDigit, int secondDigit )
        {
            if (firstDigit == 0)
            {
                toWord = $"{(Single)secondDigit}";
            }

            if (firstDigit == 1)
            {
                toWord = $"{(Double)(firstDigit - 1)}";
            }
            else
            {
                toWord += $"{(Teen)firstDigit - 2} {(secondDigit == 0 ? "" : (Single)secondDigit)}";
            }

            return this.toWord ;
        }

        /// <summary>
        /// This method converts the numbers to words 
        /// </summary>
        /// <param name="firstDigit"></param>
        /// <returns></returns>
        public string Logic(int firstDigit)
        {
            toWord = $"{(Single)firstDigit}";
            return this.toWord ;
        }




   
    
    }
}
