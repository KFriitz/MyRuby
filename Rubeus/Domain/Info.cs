using System;

namespace Myruby.Domain
{
    public static class Info
    {
        public static void ShowLogo()
        {
            Console.WriteLine("\r\n   ______        _                      ");
            Console.WriteLine("  (_____ \\      | |                     ");
            Console.WriteLine("   _____) )_   _| |__  _____ _   _  ___ ");
            Console.WriteLine("  |  __  /| | | |  _ \\| ___ | | | |/___)");
            Console.WriteLine("  | |  \\ \\| |_| | |_) ) ____| |_| |___ |");
            Console.WriteLine("  |_|   |_|____/|____/|_____)____/(___/\r\n");
            Console.WriteLine("  vX.X.X \r\n");
        }

        public static void ShowUsage()
        {
            string usage = @"
!!!!!!!!!!!!!!!!! READ THE FUCKIN MANUAL !!!!!!!!!!!!!!!!!
";
            Console.WriteLine(usage);
        }
    }
}
