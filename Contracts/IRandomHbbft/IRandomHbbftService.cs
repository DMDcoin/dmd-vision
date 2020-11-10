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
using DMDVision.Contracts.IRandomHbbft.ContractDefinition;

namespace DMDVision.Contracts.IRandomHbbft
{
    public partial class IRandomHbbftService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, IRandomHbbftDeployment iRandomHbbftDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<IRandomHbbftDeployment>().SendRequestAndWaitForReceiptAsync(iRandomHbbftDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, IRandomHbbftDeployment iRandomHbbftDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<IRandomHbbftDeployment>().SendRequestAsync(iRandomHbbftDeployment);
        }

        public static async Task<IRandomHbbftService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, IRandomHbbftDeployment iRandomHbbftDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, iRandomHbbftDeployment, cancellationTokenSource);
            return new IRandomHbbftService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public IRandomHbbftService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<BigInteger> CurrentSeedQueryAsync(CurrentSeedFunction currentSeedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CurrentSeedFunction, BigInteger>(currentSeedFunction, blockParameter);
        }

        
        public Task<BigInteger> CurrentSeedQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CurrentSeedFunction, BigInteger>(null, blockParameter);
        }
    }
}
