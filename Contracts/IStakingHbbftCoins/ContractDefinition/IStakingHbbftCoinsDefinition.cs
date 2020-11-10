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

namespace DMDVision.Contracts.IStakingHbbftCoins.ContractDefinition
{


    public partial class IStakingHbbftCoinsDeployment : IStakingHbbftCoinsDeploymentBase
    {
        public IStakingHbbftCoinsDeployment() : base(BYTECODE) { }
        public IStakingHbbftCoinsDeployment(string byteCode) : base(byteCode) { }
    }

    public class IStakingHbbftCoinsDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x6080604052348015600f57600080fd5b50603e80601d6000396000f3fe6080604052600080fdfea265627a7a72315820154f547dbc8ab4f8cb81548ff0dbdf60857b1b7dfb02fbc9b0f8be899e5687b964736f6c63430005100032";
        public IStakingHbbftCoinsDeploymentBase() : base(BYTECODE) { }
        public IStakingHbbftCoinsDeploymentBase(string byteCode) : base(byteCode) { }

    }
}
