using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    class RemoveAssessmentSubstring
    {
        static void Main(string[] args)
        {
            var rxGleimAssessmentSuffix = new Regex(@" Highest Grade\z| Lowest Grade\z| First Grade\z| Latest Grade\z| Average\z| Attempt \d{1,2}\z| Highest from \d{1,2} attempts\z");
            var titles = new string[]
            {
                "EA Part 1 SU 1 Adaptive MCQs Highest Grade",
                "EA Part 1 SU 1 HW1 Lowest Grade",
                "EA Part 1 SU 1 HW2 First Grade",
                "EA Part 1 SU 2 Adaptive MCQs Latest Grade",
                "EA Part 1 SU 2 HW1 Average",
                "EA Part 1 SU 2 HW2 Attempt 12",
                "EA Part 1 SU 3 Adaptive MCQs Highest Grade",
                "EA Part 1 SU 3 HW1 Highest from 4 attempts",
                "EA Part 1 SU 3 HW2 Average 1"
            };

            foreach(var item in titles)
            {
                Console.WriteLine(rxGleimAssessmentSuffix.Replace(item, ""));
            }

            Console.Read();
        }
    }
}
