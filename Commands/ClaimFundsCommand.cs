

namespace DMDVision.Commands 
{
  public class ClaimFundsCommand : ICommand
  {
    public string DMDAddress;
    public CommandExecutionResult Execute(CommandContext context)
    {
      return new CommandExecutionResult() { Text = "Claiming Funds..."};
    }
  }
}
