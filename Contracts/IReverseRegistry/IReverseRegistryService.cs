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
using DMDVision.Contracts.IReverseRegistry.ContractDefinition;

namespace DMDVision.Contracts.IReverseRegistry
{
    public partial class IReverseRegistryService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, IReverseRegistryDeployment iReverseRegistryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<IReverseRegistryDeployment>().SendRequestAndWaitForReceiptAsync(iReverseRegistryDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, IReverseRegistryDeployment iReverseRegistryDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<IReverseRegistryDeployment>().SendRequestAsync(iReverseRegistryDeployment);
        }

        public static async Task<IReverseRegistryService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, IReverseRegistryDeployment iReverseRegistryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, iReverseRegistryDeployment, cancellationTokenSource);
            return new IReverseRegistryService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public IReverseRegistryService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<bool> HasReverseQueryAsync(HasReverseFunction hasReverseFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<HasReverseFunction, bool>(hasReverseFunction, blockParameter);
        }

        
        public Task<bool> HasReverseQueryAsync(byte[] name, BlockParameter blockParameter = null)
        {
            var hasReverseFunction = new HasReverseFunction();
                hasReverseFunction.Name = name;
            
            return ContractHandler.QueryAsync<HasReverseFunction, bool>(hasReverseFunction, blockParameter);
        }

        public Task<string> GetReverseQueryAsync(GetReverseFunction getReverseFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetReverseFunction, string>(getReverseFunction, blockParameter);
        }

        
        public Task<string> GetReverseQueryAsync(byte[] name, BlockParameter blockParameter = null)
        {
            var getReverseFunction = new GetReverseFunction();
                getReverseFunction.Name = name;
            
            return ContractHandler.QueryAsync<GetReverseFunction, string>(getReverseFunction, blockParameter);
        }

        public Task<bool> CanReverseQueryAsync(CanReverseFunction canReverseFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CanReverseFunction, bool>(canReverseFunction, blockParameter);
        }

        
        public Task<bool> CanReverseQueryAsync(string data, BlockParameter blockParameter = null)
        {
            var canReverseFunction = new CanReverseFunction();
                canReverseFunction.Data = data;
            
            return ContractHandler.QueryAsync<CanReverseFunction, bool>(canReverseFunction, blockParameter);
        }

        public Task<string> ReverseQueryAsync(ReverseFunction reverseFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ReverseFunction, string>(reverseFunction, blockParameter);
        }

        
        public Task<string> ReverseQueryAsync(string data, BlockParameter blockParameter = null)
        {
            var reverseFunction = new ReverseFunction();
                reverseFunction.Data = data;
            
            return ContractHandler.QueryAsync<ReverseFunction, string>(reverseFunction, blockParameter);
        }
    }
}
