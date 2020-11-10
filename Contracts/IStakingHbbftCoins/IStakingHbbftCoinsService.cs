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
using DMDVision.Contracts.IStakingHbbftCoins.ContractDefinition;

namespace DMDVision.Contracts.IStakingHbbftCoins
{
    public partial class IStakingHbbftCoinsService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, IStakingHbbftCoinsDeployment iStakingHbbftCoinsDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<IStakingHbbftCoinsDeployment>().SendRequestAndWaitForReceiptAsync(iStakingHbbftCoinsDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, IStakingHbbftCoinsDeployment iStakingHbbftCoinsDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<IStakingHbbftCoinsDeployment>().SendRequestAsync(iStakingHbbftCoinsDeployment);
        }

        public static async Task<IStakingHbbftCoinsService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, IStakingHbbftCoinsDeployment iStakingHbbftCoinsDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, iStakingHbbftCoinsDeployment, cancellationTokenSource);
            return new IStakingHbbftCoinsService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public IStakingHbbftCoinsService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }


    }
}
