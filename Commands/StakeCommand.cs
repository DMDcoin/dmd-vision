

using DMDVision.Contracts.StakingHbbftCoins.ContractDefinition;

namespace DMDVision.Commands 
{
  public class StakeCommand : ValueTransferingCommand
  {
    public override CommandExecutionResult Execute(CommandContext context)
    {
      AddPoolFunction addPoolFunction = new AddPoolFunction();
      addPoolFunction.AmountToSend = this.Value;
      addPoolFunction.MiningAddress = TargetAddress;

      var task = context.Staking.ContractHandler.SendRequestAsync(addPoolFunction);
      task.Wait();
      
      if (task.Exception != null) 
      {
        return new CommandExecutionResult(true, task.Exception.ToString());
      }
      
      return new CommandExecutionResult(true, task.Result);
    }
  }

}
