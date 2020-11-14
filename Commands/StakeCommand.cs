

using DMDVision.Contracts.StakingHbbftCoins.ContractDefinition;

namespace DMDVision.Commands 
{
  public class StakeCommand : ValueTransferingCommand
  {
    public override string Execute(CommandContext context)
    {
      AddPoolFunction addPoolFunction = new AddPoolFunction();
      addPoolFunction.AmountToSend = this.Value;
      addPoolFunction.MiningAddress = TargetAddress;

      var task = context.Staking.ContractHandler.SendRequestAsync(addPoolFunction);
      task.Wait();
      
      if (task.Exception != null) 
      {
        throw task.Exception;
      }
      
      return task.Result;
    }
  }

}
