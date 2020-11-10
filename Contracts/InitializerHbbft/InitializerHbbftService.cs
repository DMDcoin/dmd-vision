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
using DMDVision.Contracts.InitializerHbbft.ContractDefinition;

namespace DMDVision.Contracts.InitializerHbbft
{
    public partial class InitializerHbbftService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, InitializerHbbftDeployment initializerHbbftDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<InitializerHbbftDeployment>().SendRequestAndWaitForReceiptAsync(initializerHbbftDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, InitializerHbbftDeployment initializerHbbftDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<InitializerHbbftDeployment>().SendRequestAsync(initializerHbbftDeployment);
        }

        public static async Task<InitializerHbbftService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, InitializerHbbftDeployment initializerHbbftDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, initializerHbbftDeployment, cancellationTokenSource);
            return new InitializerHbbftService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public InitializerHbbftService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> DataQueryAsync(DataFunction dataFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DataFunction, string>(dataFunction, blockParameter);
        }

        
        public Task<string> DataQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DataFunction, string>(null, blockParameter);
        }

        public Task<string> DestructRequestAsync(DestructFunction destructFunction)
        {
             return ContractHandler.SendRequestAsync(destructFunction);
        }

        public Task<string> DestructRequestAsync()
        {
             return ContractHandler.SendRequestAsync<DestructFunction>();
        }

        public Task<TransactionReceipt> DestructRequestAndWaitForReceiptAsync(DestructFunction destructFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(destructFunction, cancellationToken);
        }

        public Task<TransactionReceipt> DestructRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<DestructFunction>(null, cancellationToken);
        }

        public Task<string> SetDataRequestAsync(SetDataFunction setDataFunction)
        {
             return ContractHandler.SendRequestAsync(setDataFunction);
        }

        public Task<TransactionReceipt> SetDataRequestAndWaitForReceiptAsync(SetDataFunction setDataFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setDataFunction, cancellationToken);
        }

        public Task<string> SetDataRequestAsync(string data)
        {
            var setDataFunction = new SetDataFunction();
                setDataFunction.Data = data;
            
             return ContractHandler.SendRequestAsync(setDataFunction);
        }

        public Task<TransactionReceipt> SetDataRequestAndWaitForReceiptAsync(string data, CancellationTokenSource cancellationToken = null)
        {
            var setDataFunction = new SetDataFunction();
                setDataFunction.Data = data;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setDataFunction, cancellationToken);
        }
    }
}
