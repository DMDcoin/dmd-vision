using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace DMDVision.Contracts.BaseUpgradeabilityProxy.ContractDefinition
{


    public partial class BaseUpgradeabilityProxyDeployment : BaseUpgradeabilityProxyDeploymentBase
    {
        public BaseUpgradeabilityProxyDeployment() : base(BYTECODE) { }
        public BaseUpgradeabilityProxyDeployment(string byteCode) : base(byteCode) { }
    }

    public class BaseUpgradeabilityProxyDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x6080604052348015600f57600080fd5b50609d8061001e6000396000f3fe6080604052600a600c565b005b6012601e565b601e601a6020565b6045565b565b7f360894a13ba1a3210667c828492db98dca3e2076cc3735a920a3ca505d382bbc5490565b3660008037600080366000845af43d6000803e8080156063573d6000f35b3d6000fdfea265627a7a723158208548df3578715535ae653dbf0999c11e510db179e63d90a8026043f6c77eec0164736f6c63430005100032";
        public BaseUpgradeabilityProxyDeploymentBase() : base(BYTECODE) { }
        public BaseUpgradeabilityProxyDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class UpgradedEventDTO : UpgradedEventDTOBase { }

    [Event("Upgraded")]
    public class UpgradedEventDTOBase : IEventDTO
    {
        [Parameter("address", "implementation", 1, true )]
        public virtual string Implementation { get; set; }
    }
}
