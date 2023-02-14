using System;
using System.Collections.Generic;


namespace Myruby.Commands
{
    public class Tgtdeleg : ICommand
    {
        public static string CommandName => "tgtdeleg";

        public void Execute(Dictionary<string, string> arguments)
        {
            Console.WriteLine("\r\n[*] Action: Request Fake Delegation TGT (current user)\r\n");

            if (arguments.ContainsKey("/target"))
            {
                byte[] blah = LSA.RequestFakeDelegTicket(arguments["/target"]);
            }
            else
            {
                byte[] blah = LSA.RequestFakeDelegTicket();
            }
        }
    }
}