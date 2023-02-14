using System.Collections.Generic;

namespace Myruby.Commands
{
    public interface ICommand
    {
        void Execute(Dictionary<string, string> arguments);
    }
}