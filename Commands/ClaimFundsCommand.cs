

namespace DMDVision.Commands 
{
  public class ClaimFundsCommand : ICommand
  {
    public string DMDAddress;
    public string Execute(CommandContext context)
    {
      return "Claiming Funds...";
    }
  }
}
