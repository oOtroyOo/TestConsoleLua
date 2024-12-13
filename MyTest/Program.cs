using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using XLua;


class Program
{
    static void Main(string[] args)
    {
        using (LuaEnv luaEnv = new LuaEnv())
        {
            var code = File.ReadAllText("NewFile.lua", Encoding.UTF8);

            Console.WriteLine(luaEnv.DoString(code).First());

            code = "return function(str)\n" +
                   "  print(str)\n" +
                   "  return '天天都要旺'\n" +
                   "end";

            LuaFunction func = luaEnv.DoString(code).First() as LuaFunction;
            Console.WriteLine(func.Func<string, string>("今年旺不旺"));
        }

        if (!Debugger.IsAttached)
            Console.ReadKey();
    }
}