using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace week3ass
{
    class Whatunitisit
    {

        public void  Unitstotest1(int num) {
            string answer = "";
        
            string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen~" };
            string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" } ;
      
            if (num>=1000){
                    answer= ones[num/1000] + " thousand ";
                    num = num % 1000;
                
            }
            if (num >= 100) {
                answer+= ones[num / 100] + " hundred ";
                num = num % 100;
            }
            if (num >= 20) {
                answer += " " +tens[num / 10];
                num = num % 10;

            }
            if (num <= 19) {
                answer += " " + ones[num];
            }
           

            Console.WriteLine(answer);
        }
       
    }
}
