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

namespace DMDVision.Contracts.Sacrifice.ContractDefinition
{


    public partial class SacrificeDeployment : SacrificeDeploymentBase
    {
        public SacrificeDeployment() : base(BYTECODE) { }
        public SacrificeDeployment(string byteCode) : base(byteCode) { }
    }

    public class SacrificeDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x60806040526040516032380380603283398181016040526020811015602357600080fd5b50516001600160a01b038116fffe";
        public SacrificeDeploymentBase() : base(BYTECODE) { }
        public SacrificeDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_recipient", 1)]
        public virtual string Recipient { get; set; }
    }
}
