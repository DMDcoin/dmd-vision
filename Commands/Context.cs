


using System.Collections.Generic;
using System.IO;
using DMDVision.Nodes;
using Nethereum.Web3;

namespace DMDVision.Commands
{

  public class ContractsAddressInformation 
{
    // const VALIDATOR_SET_CONTRACT = '0x1000000000000000000000000000000000000001';
    // const BLOCK_REWARD_CONTRACT = '0x2000000000000000000000000000000000000001';
    // const RANDOM_CONTRACT = '0x3000000000000000000000000000000000000001';
    // const STAKING_CONTRACT = '0x1100000000000000000000000000000000000001';
    // const PERMISSION_CONTRACT = '0x4000000000000000000000000000000000000001';
    // const CERTIFIER_CONTRACT = '0x5000000000000000000000000000000000000001';
    // const KEY_GEN_HISTORY_CONTRACT = '0x7000000000000000000000000000000000000001';    

    public string HbbftStakingContract = "0x1100000000000000000000000000000000000001";
  }

  public class CommandContext
  {
    public ContractsAddressInformation ContractsAddressInformation = new ContractsAddressInformation();

    public DirectoryInfo TestnetRootDirectory { get; set; }

    private Contracts.StakingHbbft.StakingHbbftService m_Staking;
    public Contracts.StakingHbbft.StakingHbbftService Staking
    {
      get
      {
        if (m_Staking == null)
        {
          m_Staking = new Contracts.StakingHbbft.StakingHbbftService(Web3, ContractsAddressInformation.HbbftStakingContract);
        }
        return m_Staking;
      }
    }

    public Dictionary<string, NodeInfo> NodeInfos = new Dictionary<string, NodeInfo>();

    public Web3 Web3 
    {
      get;
      private set;
    }

    public CommandContext()
    {
      Web3 = new Web3();
    }
  }
}