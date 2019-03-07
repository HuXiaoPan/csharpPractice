using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    /// <summary>
    /// 闰年判断
    /// </summary>
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入年份");
            string s = Console.ReadLine();
            int year = int.Parse(s);
            bool result = (year % 100 != 0 && year % 4 == 0)||(year%400==0);
            Console.WriteLine(year + "年是闰年？" + result);
        }
    }
}
