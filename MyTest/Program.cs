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
        }

        if (!Debugger.IsAttached)
            Console.ReadKey();
    }
}