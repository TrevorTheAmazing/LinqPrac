using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPrac
{
    public static class LinqPrac
    {
        public static List<string> ProblemOneAnswer(List<string> words)
        {
            var AnswerOne = from w in words where w.Contains("th") select w;
            return AnswerOne as List<string>;
        }

        public static List<string> ProblemTwoAnswer(List<string> names)
        {
            var tempList = names.Distinct();
            var AnswerTwo = new List<string>();
            foreach (var name in tempList)
            {
                AnswerTwo.Add(name);
            }

            return AnswerTwo;
        }

        public static double  ProblemThreeAnswer(List<string> classGrades)
        {
            double tempSum = 0.0;
            var tempClassGradesList = classGrades.ToList();
            foreach (var tempClassGrades in tempClassGradesList)
            {
                var tempClass = tempClassGrades.Split(',').Select(grade => Int32.Parse(grade)).OrderBy(grade => grade).Skip(1).Average();
                tempSum += tempClass;
            }

            double tempResult = tempSum/classGrades.Count;

            return tempResult; 
        }

        public static dynamic ProblemFourAnswer(string stringIn)
        {
            stringIn = stringIn.ToLower();
            var tempString = stringIn.ToCharArray().OrderBy(c => c).GroupBy(c => c).Select(s => new { Letter = s.Select(sss => sss).ToList()[0], Count = s.Select(ss => ss).ToList().Count });

            string tempStr = "";
            foreach (var str in tempString)
            {
                tempStr += str;
            }

            return tempStr;
        }
    }
}
