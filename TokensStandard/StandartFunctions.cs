using System;
using System.Threading;

namespace TokensStandard
{
    [Script]
    public static class StandartFunctions
    {
        public static void sleep(int milliseconds) => Thread.Sleep(milliseconds);
        public static string inputln(string ask = "")
        {
            Console.Write(ask);
            return Console.ReadLine();
        }
    }
}
