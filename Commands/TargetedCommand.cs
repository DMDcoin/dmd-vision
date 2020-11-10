



using DMDVision.Commands;

namespace DMDVision.Commands
{

  public abstract class TargetedCommand : DMDVision.Commands.ICommand
  {
    public string TargetAddress;

    public abstract CommandExecutionResult Execute(CommandContext context);
  }
  
  // public abstract class ValueTransferingCommand : TargetedCommand
  // {
  //    public string Value;
  // }

}
