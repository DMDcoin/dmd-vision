




namespace DMDVision.Commands
{
  public class CommandExecutionResult
  {
    
    public bool Success;
    public string Text;  

    public CommandExecutionResult(bool success = true, string text = "")
    {
      Success = success;
      Text = text;
    }
  }

  public interface ICommand 
  {
    CommandExecutionResult Execute(CommandContext context);
  }
}