using System;
using System.Collections.Generic;
using DMDVision.Commands;

namespace dmd_vision
{
    class Program
    {
        static void Main(string[] args)
        {
            DMDVision.Commands.CommandContext context = new DMDVision.Commands.CommandContext();
            List<ICommand> commands = new List<ICommand>();

            commands.Add(new DMDVision.Commands.ClaimFundsCommand());

            foreach(ICommand command in commands) 
            {
                CommandExecutionResult result = command.Execute(context);
                Console.WriteLine(result.Text);
            }

        }

        
    }
}
