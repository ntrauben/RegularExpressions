using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //MatchMEID();

            //MatchAssessmentSection();

            //VerifyRioPassword();

            Console.Read();
        }

        static void VerifyRioPassword()
        {
            Regex rxUpperCase = new Regex(@"[A-Z]");
            Regex rxLowerCase = new Regex(@"[a-z]");
            Regex rxNumbers = new Regex(@"[0-9]");
            Regex rxSpecialChars = new Regex(@"[~`! @#$%^&*-+=\|{}()]");

            string password;

            do
            {
                Console.Write("Enter Password: ");
                password = Console.ReadLine();

                if (rxUpperCase.Matches(password).Count > 1 &&
                    rxLowerCase.Matches(password).Count > 1 &&
                    rxNumbers.Matches(password).Count > 1 &&
                    rxSpecialChars.Matches(password).Count > 1)
                {
                    Console.WriteLine("password requirements met.");
                }
                else
                {
                    Console.WriteLine("password is weak.");
                }
            }
            while (password != "");
        }

        static void MatchMEID()
        {

            Regex reMEID = new Regex(@"[(]((\p{Lu}|\p{Ll}){3}(\d){7})|((\p{Lu}|\p{Ll}){5}(\d){5})[)]");

            String word = "Traubenberg, Nikita (NIKYo95671)"; //"Inman, Gordon (Gor2043696)";

            Match mMEID = reMEID.Match(word);
            if (mMEID.Success)
            {
                String val = mMEID.Value;
                Console.WriteLine(val.Trim(new char[] { ')', '(' }));
            }
            else
            {
                Console.WriteLine("no match");
            }

        }

        static void MatchAssessmentSection()
        {
            string title = "Lab - 12.5.7.7Create Volumes";

            Regex reAsmntSec = new Regex(@"[0-9]+\.[0-9]+\.[0-9]+");

            MatchCollection assessmentSectionsMatched = reAsmntSec.Matches(title);

            foreach (Match assessmentSectionMatched in assessmentSectionsMatched)
            {
                Console.WriteLine(assessmentSectionMatched.Success ? assessmentSectionMatched.Value : "no match.");
            }
        }

        static void MatchCourseID()
        {
            String CourseModl = "GCU1"; // "ACC100-20006MTR";
            String SectionNum = "12345";
            String Weeks = "52";

            //MatrixMethods dataObj = new MatrixMethods();
            //DataSet ds = dataObj.SectionsNewForProcessing();

            Regex rex = new Regex("(\\p{Lu}|\\p{Ll})+(-(\\p{Lu}|\\p{Ll})+)?");
            MatchCollection mc = rex.Matches(CourseModl);

            //DataView dvFacChair = new DataView(ds.Tables[1]);

            foreach (Match m in mc)
            {
                Console.WriteLine(m.Value);
                // dvFacChair.RowFilter = "Prefix='" + m.Value + "'";

                //foreach(DataRow row in dvFacChair.ToTable().Rows)
                //{
                //    Console.WriteLine(row["ELRNUserID"]);

                //    StringBuilder sbAlertXML = new StringBuilder(2048);
                //    sbAlertXML.Append("<alert><description><CourseID>");
                //    sbAlertXML.Append(CourseModl);
                //    sbAlertXML.Append("</CourseID><SectionNumber>");
                //    sbAlertXML.Append(SectionNum);
                //    sbAlertXML.Append("</SectionNumber><SectionWeeks>");
                //    sbAlertXML.Append(Weeks);
                //    sbAlertXML.Append("</SectionWeeks></description></alert>");

                //    Alerts.AlertWP alertWS = new Alerts.AlertWP();
                //    // send an alert to each faculty chair informing them of mismatched calendar for a newly created section.
                //    foreach (DataRow chair in dvFacChair.ToTable().Rows)
                //    {
                //        int elrnFacUserID = (int)chair["ELRNUserID"];
                //        alertWS.CreateAlert(62, elrnFacUserID, -1, sbAlertXML.ToString());
                //    }
                //}
            }
        }
    }
}
