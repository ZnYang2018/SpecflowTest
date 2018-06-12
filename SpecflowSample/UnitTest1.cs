using System;

namespace SpecflowSample
{
    public class UnitTest1
    {
        public void TestMethod1()
        {
            // 正则表达式
            string regex = "I have entered (.*) into the calculator";

            // 可匹配的文本1- 没有中间的字符（左右空格必须有）
            string text1 = "I have entered  into the calculator";

            // 可匹配的文本2- 变化为1
            string text2 = "I have entered 1 into the calculator";

            // 可匹配的文本3- 变化为特殊字符
            string text3 = "I have entered @#￥# into the calculator";

            // 可匹配的文本4- 变化为汉子
            string text4 = "I have entered 好 into the calculator";
        }
    }
}
