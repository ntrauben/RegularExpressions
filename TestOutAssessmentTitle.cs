using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    internal class TestOutAssessmentTitle
    {
        private static readonly string[] titles =
        {
            "BPC171 - Final Exam v7",
            "01_BPC171 - Lesson 1 Assignment v7",
            "02_BPC171 - Lesson 2 Assignment v7",
            "03_BPC171 - Lesson 3 Assignment v7",
            "04_BPC171 - Lesson 4 Assignment v7",
            "05_BPC171 - Lesson 5 Assignment v7",
            "06_BPC171 - Lesson 6 Assignment v7"
        };

        public static void Main(string[] args)
        {
            Regex rxCourseVersionSuffix = new Regex(@" v[0-9]+(\.[0-9]+)?$");
            Regex rxRioCourseID = new Regex(@"^([0-9][0-9]_)?([a-z]|[A-Z]){3}[0-2][0-9]{2}(([a-z]|[A-Z]){2})? - ");

            foreach (var item in titles)
            {
                var title = rxRioCourseID.Replace(item, "");
                title = rxCourseVersionSuffix.Replace(title, "");

                Console.WriteLine(title);
            }

            Console.ReadLine();
        }
    }
}
