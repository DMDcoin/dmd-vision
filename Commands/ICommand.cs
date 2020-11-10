




namespace DMDVision.Commands
{
  public class CommandExecutionResult
  {
    public bool Success;
    public string Text;  
  }

  public interface ICommand 
  {
    CommandExecutionResult Execute(CommandContext context);
  }
}