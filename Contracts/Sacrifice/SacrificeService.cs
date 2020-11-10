using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using DMDVision.Contracts.Sacrifice.ContractDefinition;

namespace DMDVision.Contracts.Sacrifice
{
    public partial class SacrificeService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, SacrificeDeployment sacrificeDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<SacrificeDeployment>().SendRequestAndWaitForReceiptAsync(sacrificeDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, SacrificeDeployment sacrificeDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<SacrificeDeployment>().SendRequestAsync(sacrificeDeployment);
        }

        public static async Task<SacrificeService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, SacrificeDeployment sacrificeDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, sacrificeDeployment, cancellationTokenSource);
            return new SacrificeService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public SacrificeService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }


    }
}
