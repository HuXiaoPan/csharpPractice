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
            /*
             * 这里缺一个年份的健壮性判断
             * 和一个循环查询和退出的菜单
             * 懒得写over
             */
            Console.WriteLine("请输入年份");
            string s = Console.ReadLine();
            int year = int.Parse(s);
            bool result = (year % 100 != 0 && year % 4 == 0)||(year%400==0);
            Console.WriteLine(year + "年"+ (result ? "是" : "不是") + "闰年");
        }
    }
}
