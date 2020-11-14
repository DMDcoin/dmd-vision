



using System.Numerics;
using DMDVision.Commands;


namespace DMDVision.Commands
{

  public abstract class TargetedCommand : DMDVision.Commands.ICommand
  {
    public string TargetAddress;

    public abstract string Execute(CommandContext context);
  }

  public abstract class ValueTransferingCommand : TargetedCommand
  {
     public BigInteger Value;
  }
}
