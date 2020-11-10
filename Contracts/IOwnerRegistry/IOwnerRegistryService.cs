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
using DMDVision.Contracts.IOwnerRegistry.ContractDefinition;

namespace DMDVision.Contracts.IOwnerRegistry
{
    public partial class IOwnerRegistryService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, IOwnerRegistryDeployment iOwnerRegistryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<IOwnerRegistryDeployment>().SendRequestAndWaitForReceiptAsync(iOwnerRegistryDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, IOwnerRegistryDeployment iOwnerRegistryDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<IOwnerRegistryDeployment>().SendRequestAsync(iOwnerRegistryDeployment);
        }

        public static async Task<IOwnerRegistryService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, IOwnerRegistryDeployment iOwnerRegistryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, iOwnerRegistryDeployment, cancellationTokenSource);
            return new IOwnerRegistryService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public IOwnerRegistryService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> GetOwnerQueryAsync(GetOwnerFunction getOwnerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetOwnerFunction, string>(getOwnerFunction, blockParameter);
        }

        
        public Task<string> GetOwnerQueryAsync(byte[] name, BlockParameter blockParameter = null)
        {
            var getOwnerFunction = new GetOwnerFunction();
                getOwnerFunction.Name = name;
            
            return ContractHandler.QueryAsync<GetOwnerFunction, string>(getOwnerFunction, blockParameter);
        }
    }
}
