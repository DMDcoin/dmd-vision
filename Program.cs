using System;
using System.Collections.Generic;
using DMDVision.Commands;

namespace DMDVision
{
    class Program
    {
        static void Main(string[] args)
        {
            DMDVision.Commands.CommandContext context = new DMDVision.Commands.CommandContext();
            List<ICommand> commands = new List<ICommand>();

            commands.Add(new DMDVision.Commands.ClaimFundsCommand());

            var originalForegroundColor = Console.ForegroundColor;
            foreach(ICommand command in commands) 
            {
                CommandExecutionResult result = command.Execute(context);
                Console.ForegroundColor = result.Success ? originalForegroundColor : ConsoleColor.Red;
                Console.WriteLine(result.Text);
            }
        }
        
    }
}
