﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    internal class RioCourseID
    {
        static void Main(string[] args)
        {
            //var rxRioCourseID = new Regex(@"(([a-z][A-Z]){3|4})-?(([a-z][A-Z])+_)?");

            Regex rxCourseID = new Regex(@"^([a-z]|[A-Z]){3}[0-2][0-9]{2}(([a-z]|[A-Z]){2})?");

            var courseIDs = new string[] { "Dem101", "mat231ll", "us123", "nothign here", "DENTAL100-CRP" };

            foreach (var courseID in courseIDs)
            {
                Console.Write(courseID);
                Console.Write(rxCourseID.IsMatch(courseID) ? "\tis a match\t" : "\tnot a match\t");
                Console.WriteLine(rxCourseID.Match(courseID).Value);
            }

            Console.ReadLine();
        }
    }
}
