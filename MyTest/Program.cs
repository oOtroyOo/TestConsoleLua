using System;
using System.Linq;
using XLua;


class Program
{
    static void Main(string[] args)
    {
        using (LuaEnv luaEnv = new LuaEnv())
        {
            var code =
                "print('今年一定旺') \n" +
                "return '明年也要旺'";

            Console.WriteLine(luaEnv.DoString(code).First());
        }
    }
}