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
using DMDVision.Contracts.IKeyGenHistory.ContractDefinition;

namespace DMDVision.Contracts.IKeyGenHistory
{
    public partial class IKeyGenHistoryService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, IKeyGenHistoryDeployment iKeyGenHistoryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<IKeyGenHistoryDeployment>().SendRequestAndWaitForReceiptAsync(iKeyGenHistoryDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, IKeyGenHistoryDeployment iKeyGenHistoryDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<IKeyGenHistoryDeployment>().SendRequestAsync(iKeyGenHistoryDeployment);
        }

        public static async Task<IKeyGenHistoryService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, IKeyGenHistoryDeployment iKeyGenHistoryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, iKeyGenHistoryDeployment, cancellationTokenSource);
            return new IKeyGenHistoryService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public IKeyGenHistoryService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> InitializeRequestAsync(InitializeFunction initializeFunction)
        {
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(InitializeFunction initializeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<string> InitializeRequestAsync(string returnValue1, List<string> returnValue2, List<byte[]> returnValue3, List<List<byte[]>> returnValue4)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.ReturnValue1 = returnValue1;
                initializeFunction.ReturnValue2 = returnValue2;
                initializeFunction.ReturnValue3 = returnValue3;
                initializeFunction.ReturnValue4 = returnValue4;
            
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(string returnValue1, List<string> returnValue2, List<byte[]> returnValue3, List<List<byte[]>> returnValue4, CancellationTokenSource cancellationToken = null)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.ReturnValue1 = returnValue1;
                initializeFunction.ReturnValue2 = returnValue2;
                initializeFunction.ReturnValue3 = returnValue3;
                initializeFunction.ReturnValue4 = returnValue4;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<string> ClearPrevKeyGenStateRequestAsync(ClearPrevKeyGenStateFunction clearPrevKeyGenStateFunction)
        {
             return ContractHandler.SendRequestAsync(clearPrevKeyGenStateFunction);
        }

        public Task<TransactionReceipt> ClearPrevKeyGenStateRequestAndWaitForReceiptAsync(ClearPrevKeyGenStateFunction clearPrevKeyGenStateFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(clearPrevKeyGenStateFunction, cancellationToken);
        }

        public Task<string> ClearPrevKeyGenStateRequestAsync(List<string> returnValue1)
        {
            var clearPrevKeyGenStateFunction = new ClearPrevKeyGenStateFunction();
                clearPrevKeyGenStateFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAsync(clearPrevKeyGenStateFunction);
        }

        public Task<TransactionReceipt> ClearPrevKeyGenStateRequestAndWaitForReceiptAsync(List<string> returnValue1, CancellationTokenSource cancellationToken = null)
        {
            var clearPrevKeyGenStateFunction = new ClearPrevKeyGenStateFunction();
                clearPrevKeyGenStateFunction.ReturnValue1 = returnValue1;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(clearPrevKeyGenStateFunction, cancellationToken);
        }
    }
}
