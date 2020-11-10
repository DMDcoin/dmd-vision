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

namespace DMDVision.Contracts.OpenZeppelinUpgradesAddress.ContractDefinition
{


    public partial class OpenZeppelinUpgradesAddressDeployment : OpenZeppelinUpgradesAddressDeploymentBase
    {
        public OpenZeppelinUpgradesAddressDeployment() : base(BYTECODE) { }
        public OpenZeppelinUpgradesAddressDeployment(string byteCode) : base(byteCode) { }
    }

    public class OpenZeppelinUpgradesAddressDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x60556023600b82828239805160001a607314601657fe5b30600052607381538281f3fe73000000000000000000000000000000000000000030146080604052600080fdfea265627a7a72315820497a7d5389474f0de6dfbd0382f914ec22f8f3d1cfecb6c7eebcc868546520cf64736f6c63430005100032";
        public OpenZeppelinUpgradesAddressDeploymentBase() : base(BYTECODE) { }
        public OpenZeppelinUpgradesAddressDeploymentBase(string byteCode) : base(byteCode) { }

    }
}
