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

namespace DMDVision.Contracts.UpgradeableOwned.ContractDefinition
{


    public partial class UpgradeableOwnedDeployment : UpgradeableOwnedDeploymentBase
    {
        public UpgradeableOwnedDeployment() : base(BYTECODE) { }
        public UpgradeableOwnedDeployment(string byteCode) : base(byteCode) { }
    }

    public class UpgradeableOwnedDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x6080604052348015600f57600080fd5b50603e80601d6000396000f3fe6080604052600080fdfea265627a7a723158205305659a1d93d5ce64cfdce2277a8e040391cca5e9971a37ae33e38289fe65c064736f6c63430005100032";
        public UpgradeableOwnedDeploymentBase() : base(BYTECODE) { }
        public UpgradeableOwnedDeploymentBase(string byteCode) : base(byteCode) { }

    }
}
